using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KURSISHI_11
{
    public partial class AdminForm : Form
    {
        string connStr = "server=localhost;user=root;password=;database=baza3topshiriq;";
        int tanlanganFoydalanuvchiId = -1;
        private int adminId;

        public AdminForm(int adminId)
        {
            this.adminId = adminId;
            InitializeComponent();
         
            this.WindowState = FormWindowState.Maximized;
            FanlarniYuklash();
            GuruhlarniYuklash();
            RolniYuklash();
            FoydalanuvchilarniYuklash();
            FoydalanuvchiIsminiChiqar();
            DgvFanlarniYuklash(); 
            DgvGuruhlarniYuklash();
        }

        private void RolniYuklash()
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("admin");
            cmbRol.Items.Add("uqtuvchi");
            cmbRol.Items.Add("uquvchi");
            cmbRol.SelectedIndex = 0;
        }
        private void FoydalanuvchiIsminiChiqar()
        {
            using (var con = new MySqlConnection(connStr))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT ismi, familiya FROM foydalanuvchilar WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", adminId);
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
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, nomi FROM fanlar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbFanlar.DataSource = dt;
                cmbFanlar.DisplayMember = "nomi";
                cmbFanlar.ValueMember = "id";
            }
            DgvFanlarniYuklash();
        }

        private void GuruhlarniYuklash()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, nomi FROM guruhlar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbGuruhlar.DataSource = dt;
                cmbGuruhlar.DisplayMember = "nomi";
                cmbGuruhlar.ValueMember = "id";
            }
            DgvGuruhlarniYuklash();
        }

        private void FoydalanuvchilarniYuklash()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = @"SELECT f.id, f.ismi, f.familiya, f.login, f.parol, f.rol,
                                g.nomi AS guruh, fan.nomi AS fan 
                                FROM foydalanuvchilar f
                                LEFT JOIN guruhlar g ON f.guruh_id = g.id
                                LEFT JOIN fanlar fan ON f.fan_id = fan.id";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvFoydalanuvchilar.DataSource = dt;
            }
        }
        private void DgvFanlarniYuklash()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, nomi FROM fanlar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvFanlar.DataSource = dt;
            }
        }
        private void DgvGuruhlarniYuklash()
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id, nomi FROM guruhlar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGuruhlar.DataSource = dt;
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            groupBox1.SendToBack();
            groupBox2.SendToBack();
            groupBox3.SendToBack();
            

        }

        private void btnQushish_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"INSERT INTO foydalanuvchilar 
                                (ismi, familiya, login, parol, rol, guruh_id, fan_id) 
                                VALUES (@ism, @familiya, @login, @parol, @rol, @guruh_id, @fan_id)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ism", txtIsm.Text);
                cmd.Parameters.AddWithValue("@familiya", txtFamiliya.Text);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@parol", txtParol.Text);
                cmd.Parameters.AddWithValue("@rol", cmbRol.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@guruh_id", cmbGuruhlar.SelectedValue);
                cmd.Parameters.AddWithValue("@fan_id", cmbFanlar.SelectedValue);
                cmd.ExecuteNonQuery();
                FoydalanuvchilarniYuklash();
                Tozalash();
            }
        }

        private void dgvFoydalanuvchilar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tanlanganFoydalanuvchiId = Convert.ToInt32(dgvFoydalanuvchilar.Rows[e.RowIndex].Cells["id"].Value);
                txtIsm.Text = dgvFoydalanuvchilar.Rows[e.RowIndex].Cells["ismi"].Value.ToString();
                txtFamiliya.Text = dgvFoydalanuvchilar.Rows[e.RowIndex].Cells["familiya"].Value.ToString();
                txtLogin.Text = dgvFoydalanuvchilar.Rows[e.RowIndex].Cells["login"].Value.ToString();
                txtParol.Text = dgvFoydalanuvchilar.Rows[e.RowIndex].Cells["parol"].Value.ToString();
                cmbRol.SelectedItem = dgvFoydalanuvchilar.Rows[e.RowIndex].Cells["rol"].Value.ToString();
                cmbGuruhlar.Text = dgvFoydalanuvchilar.Rows[e.RowIndex].Cells["guruh"].Value.ToString();
                cmbFanlar.Text = dgvFoydalanuvchilar.Rows[e.RowIndex].Cells["fan"].Value.ToString();
            }
        }

        private void btnTahrirlash_Click(object sender, EventArgs e)
        {
            if (tanlanganFoydalanuvchiId < 0)
            {
                MessageBox.Show("Tahrirlash uchun foydalanuvchi tanlang!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = @"UPDATE foydalanuvchilar SET
                                ismi=@ism, familiya=@familiya, login=@login, parol=@parol, rol=@rol,
                                guruh_id=@guruh_id, fan_id=@fan_id
                                WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", tanlanganFoydalanuvchiId);
                cmd.Parameters.AddWithValue("@ism", txtIsm.Text);
                cmd.Parameters.AddWithValue("@familiya", txtFamiliya.Text);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text);
                cmd.Parameters.AddWithValue("@parol", txtParol.Text);
                cmd.Parameters.AddWithValue("@rol", cmbRol.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@guruh_id", cmbGuruhlar.SelectedValue);
                cmd.Parameters.AddWithValue("@fan_id", cmbFanlar.SelectedValue);
                cmd.ExecuteNonQuery();
                FoydalanuvchilarniYuklash();
                Tozalash();
            }
        }

        private void btnOchirish_Click(object sender, EventArgs e)
        {
            if (tanlanganFoydalanuvchiId < 0)
            {
                MessageBox.Show("O‘chirish uchun foydalanuvchi tanlang!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                string query = "DELETE FROM foydalanuvchilar WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", tanlanganFoydalanuvchiId);
                cmd.ExecuteNonQuery();
                FoydalanuvchilarniYuklash();
                Tozalash();
            }
        }

        private void Tozalash()
        {
            txtIsm.Clear();
            txtFamiliya.Clear();
            txtLogin.Clear();
            txtParol.Clear();
            cmbRol.SelectedIndex = 0;
            cmbFanlar.SelectedIndex = -1;
            cmbGuruhlar.SelectedIndex = -1;
            tanlanganFoydalanuvchiId = -1;
        }

        private void btnFanQushish_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO fanlar (nomi) VALUES (@nomi)", conn);
                cmd.Parameters.AddWithValue("@nomi", txtFanNomi.Text);
                cmd.ExecuteNonQuery();
                FanlarniYuklash();
                txtFanNomi.Clear();
            }
        }

        private void btnFanOchirish_Click(object sender, EventArgs e)
        {
            if (dgvFanlar.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvFanlar.SelectedRows[0].Cells[0].Value);
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM fanlar WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    FanlarniYuklash();
                }
            }
        }

        private void btnGuruhQushish_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO guruhlar (nomi) VALUES (@nomi)", conn);
                cmd.Parameters.AddWithValue("@nomi", txtGuruhNomi.Text);
                cmd.ExecuteNonQuery();
                GuruhlarniYuklash();
                txtGuruhNomi.Clear();
            }
        }

        private void btnGuruhOchirish_Click(object sender, EventArgs e)
        {
            if (dgvGuruhlar.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvGuruhlar.SelectedRows[0].Cells[0].Value);
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM guruhlar WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    GuruhlarniYuklash();
                }
            }
            else
            {
                MessageBox.Show("Iltimos, o'chirish uchun guruhni tanlang.");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Visible=true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatForm chat = new ChatForm(adminId);
            chat.Visible=true;
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
