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
    public partial class LoginParolUzgartirish : Form
    {
        private int foydalanuvchiId;
        private string userRole;
        string connectionString = "server=localhost;user=root;password=;database=Elektron_db;";
        public LoginParolUzgartirish(int foydalanuvchiId)
        {
            InitializeComponent();
            this.foydalanuvchiId = foydalanuvchiId;
            FoydalanuvchiRoliniAniqlash();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }
        private void FoydalanuvchiRoliniAniqlash()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT rol FROM foydalanuvchilar WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", foydalanuvchiId);
                    object result = cmd.ExecuteScalar();
                    userRole = result?.ToString() ?? "";
                }
            }
        }

        private void LoginParolUzgartirish_Load(object sender, EventArgs e)
        {
           
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Anchor = AnchorStyles.None;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string parol = textBox2.Text.Trim();

            if (login == "" || parol == "")
            {
                MessageBox.Show("Iltimos, login va parol kiriting!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM foydalanuvchilar WHERE login = @login AND parol = @parol";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@parol", parol);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        
                        textBox3.Visible = true;
                        textBox4.Visible = true; 
                        button2.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show("Login yoki parol noto‘g‘ri!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xatolik: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string eskiLogin = textBox1.Text.Trim();
            string eskiParol = textBox2.Text.Trim();
            string yangiLogin = textBox3.Text.Trim();
            string yangiParol = textBox4.Text.Trim();

            if (yangiLogin == "" || yangiParol == "")
            {
                MessageBox.Show("Yangi login va parolni kiriting!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE foydalanuvchilar SET login = @ylogin, parol = @yparol WHERE login = @elogin AND parol = @eparol";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@ylogin", yangiLogin);
                    cmd.Parameters.AddWithValue("@yparol", yangiParol);
                    cmd.Parameters.AddWithValue("@elogin", eskiLogin);
                    cmd.Parameters.AddWithValue("@eparol", eskiParol);

                    int affected = cmd.ExecuteNonQuery();

                    if (affected > 0)
                    {
                        MessageBox.Show("Login va parol muvaffaqiyatli o‘zgartirildi!");
                        
                    }
                    else
                    {
                        MessageBox.Show("O‘zgartirish amalga oshmadi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xatolik: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            switch (userRole)
            {
                case "admin":
                    AdminForm adminForm = new AdminForm(foydalanuvchiId);
                    adminForm.FormClosed += (s, args) => this.Close();
                    adminForm.Show();
                    break;
                case "uqtuvchi":
                    UqtuvchiForm uqtuvchiForm = new UqtuvchiForm(foydalanuvchiId);
                    uqtuvchiForm.FormClosed += (s, args) => this.Close();
                    uqtuvchiForm.Show();
                    break;
                case "uquvchi":
                    UquvchiForm uquvchiForm = new UquvchiForm(foydalanuvchiId);
                    uquvchiForm.FormClosed += (s, args) => this.Close();
                    uquvchiForm.Show();
                    break;
                default:
                    MessageBox.Show("Rol aniqlanmadi!");
                    this.Close();
                    break;
            }
        }
    }
}
