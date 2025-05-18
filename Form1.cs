using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KURSISHI_11
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            txtLogin.Focus(); 
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Anchor = AnchorStyles.None;
            txtParol.PasswordChar = '*';
        }

        private void btnKirish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtParol.Text))
            {
                MessageBox.Show("Login va parol maydonlari bo'sh bo'lishi mumkin emas!", "Diqqat",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = "server=localhost;user=root;password=;database=Elektron_db;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, rol FROM foydalanuvchilar WHERE login = @login AND parol = @parol";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@login", txtLogin.Text.Trim());
                        cmd.Parameters.AddWithValue("@parol", txtParol.Text);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows && reader.Read())
                            {
                                string rol = reader["rol"].ToString();
                                int foydalanuvchiId = reader.GetInt32("id");

                                this.Hide();

                                switch (rol)
                                {
                                    case "admin":
                                        new AdminForm(foydalanuvchiId).Show();
                                        this.Hide();
                                        break;
                                    case "uqtuvchi":
                                        new UqtuvchiForm(foydalanuvchiId).Show();
                                        this.Hide();
                                        break;
                                    case "uquvchi":
                                        new UquvchiForm(foydalanuvchiId).Show();
                                        this.Hide();
                                        break;
                                    default:
                                        MessageBox.Show("Noma'lum rol.", "Xatolik",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Login yoki parol noto'g'ri!", "Xatolik",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database xatosi: {ex.Message}", "Xatolik",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xatolik yuz berdi: {ex.Message}", "Xatolik",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               // this.Show(); 
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
               
                txtParol.PasswordChar = '\0'; 
            }
            else
            {
                txtParol.PasswordChar = '*';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}