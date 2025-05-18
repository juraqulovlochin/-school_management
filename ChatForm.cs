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
    public partial class ChatForm : Form
    {
        private int foydalanuvchiId;

        private string connectionString = "server=localhost;user=root;password=;database=Elektron_db;";
        private string userRole;
        public ChatForm(int foydalanuvchiId)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.foydalanuvchiId = foydalanuvchiId;
            FoydalanuvchiRoliniAniqlash();
            XabarlarniYuklash();
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

            panel2.Left = (this.ClientSize.Width - panel2.Width) / 2;
            panel2.Top = (this.ClientSize.Height - panel2.Height) / 2;
            panel2.Anchor = AnchorStyles.None;

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

        private void btnYuborish_Click(object sender, EventArgs e)
        {
            string matn = txtXabar.Text.Trim();
            if (matn == "") return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO xabarlar (foydalanuvchi_id, matn) VALUES (@id, @matn)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", foydalanuvchiId);
                    cmd.Parameters.AddWithValue("@matn", matn);
                    cmd.ExecuteNonQuery();
                }
            }

            txtXabar.Text = "";
            XabarlarniYuklash();
        }
        private void XabarlarniYuklash()
        {
            lstXabarlar.Items.Clear();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT f.ismi, f.rol, x.matn, x.sana_vaqt 
                             FROM xabarlar x 
                             JOIN foydalanuvchilar f ON f.id = x.foydalanuvchi_id
                             ORDER BY x.sana_vaqt ASC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ism = reader.GetString("ismi");
                        string rol = reader.GetString("rol");
                        string matn = reader.GetString("matn");
                        DateTime vaqt = reader.GetDateTime("sana_vaqt");

                        lstXabarlar.Items.Add($"[{vaqt:HH:mm}] {ism} ({rol}): {matn}");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void txtXabar_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
