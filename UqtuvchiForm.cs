using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KURSISHI_11
{
    public partial class UqtuvchiForm : Form
    {
        private readonly string connectionString = "server=localhost;user=root;password=;database=Elektron_db";
        private readonly int uqtuvchiId;

        public UqtuvchiForm(int uqtuvchiId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.uqtuvchiId = uqtuvchiId;
            FoydalanuvchiIsminiChiqar();
            GuruhlarniYuklash();
            FanlarniYuklash();
            cmbGuruhlar.SelectedIndexChanged += combo_SelectedIndexChanged;
            cmbFanlar.SelectedIndexChanged += combo_SelectedIndexChanged;
        }
        private void FoydalanuvchiIsminiChiqar()
        {
            using (var con = new MySqlConnection(connectionString)) 
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT ismi, familiya FROM foydalanuvchilar WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", uqtuvchiId);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblIsm.Text = $"{reader["ismi"]} {reader["familiya"]}";
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ismni yuklashda xatolik: " + ex.Message);
                    con.Close();
                }
            }
        }

        private void FanlarniYuklash()
        {
            using (var con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var cmd = new MySqlCommand("SELECT id, nomi FROM fanlar WHERE id IN (SELECT fan_id FROM foydalanuvchilar WHERE id = @id)", con);
                    cmd.Parameters.AddWithValue("@id", uqtuvchiId);
                    var da = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    cmbFanlar.DataSource = dt;
                    cmbFanlar.DisplayMember = "nomi";
                    cmbFanlar.ValueMember = "id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fanlarni yuklashda xatolik: " + ex.Message);
                }
            }
        }

        private void GuruhlarniYuklash()
        {
            using (var con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var cmd = new MySqlCommand("SELECT DISTINCT g.id, g.nomi FROM guruhlar g JOIN foydalanuvchilar f ON f.guruh_id = g.id WHERE f.fan_id IN (SELECT fan_id FROM foydalanuvchilar WHERE id = @id)", con);
                    cmd.Parameters.AddWithValue("@id", uqtuvchiId);
                    var da = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    cmbGuruhlar.DataSource = dt;
                    cmbGuruhlar.DisplayMember = "nomi";
                    cmbGuruhlar.ValueMember = "id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Guruhlarni yuklashda xatolik: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbFanlar.SelectedValue == null || cmbFanlar.SelectedValue == DBNull.Value)
            {
                MessageBox.Show("Iltimos, fanni tanlang!");
                return;
            }

            int fanId = Convert.ToInt32(cmbFanlar.SelectedValue);

            using (var con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    foreach (DataGridViewRow row in dgvDavomat.Rows)
                    {
                        if (row.IsNewRow) continue;
                        int uquvchi_id = Convert.ToInt32(row.Cells["id"].Value);
                        string holat = row.Cells["davomat"].Value?.ToString();
                        string baho = row.Cells["baho"].Value?.ToString();
                        var cmd = new MySqlCommand("INSERT INTO davomat (uquvchi_id, fan_id, sana, baho, holat) VALUES (@uquvchi_id, @fan_id, @sana, @baho, @holat)", con);
                        cmd.Parameters.AddWithValue("@uquvchi_id", uquvchi_id);
                        cmd.Parameters.AddWithValue("@fan_id", fanId);
                        cmd.Parameters.AddWithValue("@sana", DateTime.Now);
                        cmd.Parameters.AddWithValue("@baho", string.IsNullOrEmpty(baho) ? (object)DBNull.Value : baho);
                        cmd.Parameters.AddWithValue("@holat", string.IsNullOrEmpty(holat) ? (object)DBNull.Value : holat);
                        cmd.ExecuteNonQuery();
                    }

                    string selectQuery = @"
                        SELECT u.ismi, u.familiya, f.nomi AS fan_nomi, d.baho, d.holat, d.sana 
                        FROM davomat d
                        JOIN foydalanuvchilar u ON d.uquvchi_id = u.id
                        JOIN fanlar f ON d.fan_id = f.id
                        WHERE d.sana = @sana";
                    var selectCmd = new MySqlCommand(selectQuery, con);
                    selectCmd.Parameters.AddWithValue("@sana", DateTime.Now.Date);

                    using (var reader = selectCmd.ExecuteReader())
                    {
                        string result = "";
                        while (reader.Read())
                        {
                            string ism = reader["ismi"].ToString();
                            string familiya = reader["familiya"].ToString();
                            string fan_nomi = reader["fan_nomi"].ToString();
                            string baho = reader["baho"].ToString();
                            string holat = reader["holat"].ToString();
                            string sana = reader["sana"].ToString();
                            result += $"Ism: {ism}, Familiya: {familiya}, Fan: {fan_nomi}, Baho: {baho}, Davomat: {holat}, Sana: {sana}\n";
                        }
                        MessageBox.Show(result, "Saqlangan ma'lumotlar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ma'lumotlarni saqlashda xatolik: " + ex.Message);
                }
            }
    
        }

        private void cmbGuruhlar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void UqtuvchiForm_Load(object sender, EventArgs e)
        {
            
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbGuruhlar.SelectedValue == null || cmbFanlar.SelectedValue == null) return;

            int guruhId = Convert.ToInt32(cmbGuruhlar.SelectedValue);
            int fanId = Convert.ToInt32(cmbFanlar.SelectedValue);

            using (var con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT id, ismi, familiya 
                FROM foydalanuvchilar 
                WHERE guruh_id = @guruhId AND fan_id = @fanId AND rol='uquvchi';";

                    var cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@guruhId", guruhId);
                    cmd.Parameters.AddWithValue("@fanId", fanId);

                    var da = new MySqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);

                    // 1. DataGridViewni tozalash va mavjud ustunlarni o'chirish
                    dgvDavomat.DataSource = null;
                    dgvDavomat.Columns.Clear();
                    dgvDavomat.Rows.Clear();

                    // 2. Asosiy ustunlarni qo'shish (id, ismi, familiya)
                    dgvDavomat.Columns.Add("id", "ID");
                    dgvDavomat.Columns.Add("ismi", "Ismi");
                    dgvDavomat.Columns.Add("familiya", "Familiya");

                    // 3. ComboBox ustunlarini qo'shish
                    DataGridViewComboBoxColumn davomatColumn = new DataGridViewComboBoxColumn();
                    davomatColumn.HeaderText = "Davomat";
                    davomatColumn.Name = "davomat";
                    davomatColumn.Items.AddRange("Bor", "Yo'q");
                    dgvDavomat.Columns.Add(davomatColumn);

                    DataGridViewComboBoxColumn bahoColumn = new DataGridViewComboBoxColumn();
                    bahoColumn.HeaderText = "Baho";
                    bahoColumn.Name = "baho";
                    bahoColumn.Items.AddRange("", "0", "3", "4", "5");
                    dgvDavomat.Columns.Add(bahoColumn);

                    // 4. Jadvarga ma'lumotlarni qo'shish
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvDavomat.Rows.Add(
                            row["id"],
                            row["ismi"],
                            row["familiya"],
                            "Bor", // Davomat uchun standart qiymat
                            ""     // Baho uchun standart qiymat
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("O'quvchilarni yuklashda xatolik: " + ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Visible=true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginParolUzgartirish uzgartirish = new LoginParolUzgartirish(uqtuvchiId);
            uzgartirish.ShowDialog();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatForm chat = new ChatForm(uqtuvchiId);
            chat.Show();
            this.Visible = false;
        }

        private void dgvDavomat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}