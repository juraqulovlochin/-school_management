namespace KURSISHI_11
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFoydalanuvchilar = new System.Windows.Forms.DataGridView();
            this.txtIsm = new System.Windows.Forms.TextBox();
            this.txtFamiliya = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtParol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.cmbGuruhlar = new System.Windows.Forms.ComboBox();
            this.cmbFanlar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnQushish = new System.Windows.Forms.Button();
            this.btnTahrirlash = new System.Windows.Forms.Button();
            this.btnOchirish = new System.Windows.Forms.Button();
            this.dgvFanlar = new System.Windows.Forms.DataGridView();
            this.dgvGuruhlar = new System.Windows.Forms.DataGridView();
            this.txtFanNomi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFanQushish = new System.Windows.Forms.Button();
            this.btnFanOchirish = new System.Windows.Forms.Button();
            this.btnGuruhQushish = new System.Windows.Forms.Button();
            this.btnGuruhOchirish = new System.Windows.Forms.Button();
            this.txtGuruhNomi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIsm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoydalanuvchilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuruhlar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFoydalanuvchilar
            // 
            this.dgvFoydalanuvchilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoydalanuvchilar.Location = new System.Drawing.Point(226, 80);
            this.dgvFoydalanuvchilar.Name = "dgvFoydalanuvchilar";
            this.dgvFoydalanuvchilar.Size = new System.Drawing.Size(715, 153);
            this.dgvFoydalanuvchilar.TabIndex = 0;
            this.dgvFoydalanuvchilar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoydalanuvchilar_CellContentClick);
            // 
            // txtIsm
            // 
            this.txtIsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIsm.Location = new System.Drawing.Point(490, 251);
            this.txtIsm.Name = "txtIsm";
            this.txtIsm.Size = new System.Drawing.Size(100, 26);
            this.txtIsm.TabIndex = 1;
            // 
            // txtFamiliya
            // 
            this.txtFamiliya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFamiliya.Location = new System.Drawing.Point(309, 252);
            this.txtFamiliya.Name = "txtFamiliya";
            this.txtFamiliya.Size = new System.Drawing.Size(100, 26);
            this.txtFamiliya.TabIndex = 2;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.Location = new System.Drawing.Point(309, 282);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 26);
            this.txtLogin.TabIndex = 3;
            // 
            // txtParol
            // 
            this.txtParol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtParol.Location = new System.Drawing.Point(490, 282);
            this.txtParol.Name = "txtParol";
            this.txtParol.Size = new System.Drawing.Size(100, 26);
            this.txtParol.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(447, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ism";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(237, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Familiya";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(255, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(439, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parol";
            // 
            // cmbRol
            // 
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(664, 314);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 26);
            this.cmbRol.TabIndex = 9;
            // 
            // cmbGuruhlar
            // 
            this.cmbGuruhlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbGuruhlar.FormattingEnabled = true;
            this.cmbGuruhlar.Location = new System.Drawing.Point(309, 314);
            this.cmbGuruhlar.Name = "cmbGuruhlar";
            this.cmbGuruhlar.Size = new System.Drawing.Size(100, 26);
            this.cmbGuruhlar.TabIndex = 10;
            // 
            // cmbFanlar
            // 
            this.cmbFanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbFanlar.FormattingEnabled = true;
            this.cmbFanlar.Location = new System.Drawing.Point(490, 313);
            this.cmbFanlar.Name = "cmbFanlar";
            this.cmbFanlar.Size = new System.Drawing.Size(100, 26);
            this.cmbFanlar.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(447, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(625, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(249, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Guruh";
            // 
            // btnQushish
            // 
            this.btnQushish.BackColor = System.Drawing.Color.Bisque;
            this.btnQushish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQushish.Location = new System.Drawing.Point(853, 252);
            this.btnQushish.Name = "btnQushish";
            this.btnQushish.Size = new System.Drawing.Size(88, 27);
            this.btnQushish.TabIndex = 15;
            this.btnQushish.Text = "Qo\'shish";
            this.btnQushish.UseVisualStyleBackColor = false;
            this.btnQushish.Click += new System.EventHandler(this.btnQushish_Click);
            // 
            // btnTahrirlash
            // 
            this.btnTahrirlash.BackColor = System.Drawing.Color.Bisque;
            this.btnTahrirlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTahrirlash.Location = new System.Drawing.Point(853, 282);
            this.btnTahrirlash.Name = "btnTahrirlash";
            this.btnTahrirlash.Size = new System.Drawing.Size(88, 27);
            this.btnTahrirlash.TabIndex = 16;
            this.btnTahrirlash.Text = "Tahrirlash";
            this.btnTahrirlash.UseVisualStyleBackColor = false;
            this.btnTahrirlash.Click += new System.EventHandler(this.btnTahrirlash_Click);
            // 
            // btnOchirish
            // 
            this.btnOchirish.BackColor = System.Drawing.Color.Bisque;
            this.btnOchirish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOchirish.Location = new System.Drawing.Point(853, 312);
            this.btnOchirish.Name = "btnOchirish";
            this.btnOchirish.Size = new System.Drawing.Size(88, 27);
            this.btnOchirish.TabIndex = 17;
            this.btnOchirish.Text = "O\'chirish";
            this.btnOchirish.UseVisualStyleBackColor = false;
            this.btnOchirish.Click += new System.EventHandler(this.btnOchirish_Click);
            // 
            // dgvFanlar
            // 
            this.dgvFanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFanlar.Location = new System.Drawing.Point(226, 368);
            this.dgvFanlar.Name = "dgvFanlar";
            this.dgvFanlar.Size = new System.Drawing.Size(331, 131);
            this.dgvFanlar.TabIndex = 18;
            // 
            // dgvGuruhlar
            // 
            this.dgvGuruhlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuruhlar.Location = new System.Drawing.Point(582, 368);
            this.dgvGuruhlar.Name = "dgvGuruhlar";
            this.dgvGuruhlar.Size = new System.Drawing.Size(356, 131);
            this.dgvGuruhlar.TabIndex = 19;
            // 
            // txtFanNomi
            // 
            this.txtFanNomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFanNomi.Location = new System.Drawing.Point(295, 506);
            this.txtFanNomi.Name = "txtFanNomi";
            this.txtFanNomi.Size = new System.Drawing.Size(100, 24);
            this.txtFanNomi.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(219, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fan nomi";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnFanQushish
            // 
            this.btnFanQushish.BackColor = System.Drawing.Color.Bisque;
            this.btnFanQushish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFanQushish.Location = new System.Drawing.Point(401, 505);
            this.btnFanQushish.Name = "btnFanQushish";
            this.btnFanQushish.Size = new System.Drawing.Size(75, 27);
            this.btnFanQushish.TabIndex = 22;
            this.btnFanQushish.Text = "Qo\'shish";
            this.btnFanQushish.UseVisualStyleBackColor = false;
            this.btnFanQushish.Click += new System.EventHandler(this.btnFanQushish_Click);
            // 
            // btnFanOchirish
            // 
            this.btnFanOchirish.BackColor = System.Drawing.Color.Bisque;
            this.btnFanOchirish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFanOchirish.Location = new System.Drawing.Point(482, 506);
            this.btnFanOchirish.Name = "btnFanOchirish";
            this.btnFanOchirish.Size = new System.Drawing.Size(75, 27);
            this.btnFanOchirish.TabIndex = 23;
            this.btnFanOchirish.Text = "O\'chirish";
            this.btnFanOchirish.UseVisualStyleBackColor = false;
            this.btnFanOchirish.Click += new System.EventHandler(this.btnFanOchirish_Click);
            // 
            // btnGuruhQushish
            // 
            this.btnGuruhQushish.BackColor = System.Drawing.Color.Bisque;
            this.btnGuruhQushish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGuruhQushish.Location = new System.Drawing.Point(782, 504);
            this.btnGuruhQushish.Name = "btnGuruhQushish";
            this.btnGuruhQushish.Size = new System.Drawing.Size(75, 27);
            this.btnGuruhQushish.TabIndex = 24;
            this.btnGuruhQushish.Text = "Qoshish";
            this.btnGuruhQushish.UseVisualStyleBackColor = false;
            this.btnGuruhQushish.Click += new System.EventHandler(this.btnGuruhQushish_Click);
            // 
            // btnGuruhOchirish
            // 
            this.btnGuruhOchirish.BackColor = System.Drawing.Color.Bisque;
            this.btnGuruhOchirish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGuruhOchirish.Location = new System.Drawing.Point(863, 503);
            this.btnGuruhOchirish.Name = "btnGuruhOchirish";
            this.btnGuruhOchirish.Size = new System.Drawing.Size(75, 27);
            this.btnGuruhOchirish.TabIndex = 25;
            this.btnGuruhOchirish.Text = "O\'chirish";
            this.btnGuruhOchirish.UseVisualStyleBackColor = false;
            this.btnGuruhOchirish.Click += new System.EventHandler(this.btnGuruhOchirish_Click);
            // 
            // txtGuruhNomi
            // 
            this.txtGuruhNomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGuruhNomi.Location = new System.Drawing.Point(676, 504);
            this.txtGuruhNomi.Name = "txtGuruhNomi";
            this.txtGuruhNomi.Size = new System.Drawing.Size(100, 24);
            this.txtGuruhNomi.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.RosyBrown;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(579, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Guruh nomi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 58);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(370, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(415, 31);
            this.label10.TabIndex = 1;
            this.label10.Text = "Foydalanuvchilarni nazorat qilish ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblIsm);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 495);
            this.panel2.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Bisque;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(33, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "Xabarlar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(33, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Chiqish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIsm
            // 
            this.lblIsm.AutoSize = true;
            this.lblIsm.Location = new System.Drawing.Point(47, 73);
            this.lblIsm.Name = "lblIsm";
            this.lblIsm.Size = new System.Drawing.Size(56, 13);
            this.lblIsm.TabIndex = 8;
            this.lblIsm.Text = "Amdin ismi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KURSISHI_11.Properties.Resources._240_F_229758328_7x8jwCwjtBMmC6rgFzLFhZoEpLobB6L8;
            this.pictureBox1.Location = new System.Drawing.Point(50, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(197, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 132);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Foydalanuvchilar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(197, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 204);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fanlar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(563, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 207);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Guruhlar";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 553);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGuruhNomi);
            this.Controls.Add(this.btnGuruhOchirish);
            this.Controls.Add(this.btnGuruhQushish);
            this.Controls.Add(this.btnFanOchirish);
            this.Controls.Add(this.btnFanQushish);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFanNomi);
            this.Controls.Add(this.dgvGuruhlar);
            this.Controls.Add(this.dgvFanlar);
            this.Controls.Add(this.btnOchirish);
            this.Controls.Add(this.btnTahrirlash);
            this.Controls.Add(this.btnQushish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFanlar);
            this.Controls.Add(this.cmbGuruhlar);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParol);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtFamiliya);
            this.Controls.Add(this.txtIsm);
            this.Controls.Add(this.dgvFoydalanuvchilar);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoydalanuvchilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuruhlar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFoydalanuvchilar;
        private System.Windows.Forms.TextBox txtIsm;
        private System.Windows.Forms.TextBox txtFamiliya;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtParol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.ComboBox cmbGuruhlar;
        private System.Windows.Forms.ComboBox cmbFanlar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnQushish;
        private System.Windows.Forms.Button btnTahrirlash;
        private System.Windows.Forms.Button btnOchirish;
        private System.Windows.Forms.DataGridView dgvFanlar;
        private System.Windows.Forms.DataGridView dgvGuruhlar;
        private System.Windows.Forms.TextBox txtFanNomi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFanQushish;
        private System.Windows.Forms.Button btnFanOchirish;
        private System.Windows.Forms.Button btnGuruhQushish;
        private System.Windows.Forms.Button btnGuruhOchirish;
        private System.Windows.Forms.TextBox txtGuruhNomi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIsm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}