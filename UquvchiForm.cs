using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace KURSISHI_11
{
    public partial class UquvchiForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user=root;password=;database=Elektron_db");
        int uquvchiId;

        public UquvchiForm(int uquvchiId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.uquvchiId = uquvchiId;
            FoydalanuvchiIsminiChiqar();
            NatijalarniYuklash();
        }

        private void FoydalanuvchiIsminiChiqar()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT ismi, familiya FROM foydalanuvchilar WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", uquvchiId);
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

        private void NatijalarniYuklash()
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(@"
                    SELECT f.nomi AS Fan, d.sana, d.holat, d.baho
                    FROM davomat d
                    JOIN foydalanuvchilar fu ON fu.id = d.uquvchi_id
                    JOIN fanlar f ON f.id = fu.fan_id
                    WHERE d.uquvchi_id = @id
                    ORDER BY d.sana DESC", con);

                cmd.Parameters.AddWithValue("@id", uquvchiId);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNatijalar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Natijalarni yuklashda xatolik: " + ex.Message);
            }
        }

        private void UquvchiForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Visible=true;
            this.Visible=false;
          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();    
            LoginParolUzgartirish uzgartirish=new LoginParolUzgartirish(uquvchiId);
            uzgartirish.ShowDialog();
            this.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChatForm chat = new ChatForm(uquvchiId);
            chat.Show();
            this.Visible = false;
        }

        private void dgvNatijalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
