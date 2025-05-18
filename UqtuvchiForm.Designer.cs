namespace KURSISHI_11
{
    partial class UqtuvchiForm
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
            this.dgvDavomat = new System.Windows.Forms.DataGridView();
            this.cmbGuruhlar = new System.Windows.Forms.ComboBox();
            this.btnSaqlash = new System.Windows.Forms.Button();
            this.cmbFanlar = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIsm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDavomat)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDavomat
            // 
            this.dgvDavomat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDavomat.Location = new System.Drawing.Point(197, 54);
            this.dgvDavomat.Name = "dgvDavomat";
            this.dgvDavomat.Size = new System.Drawing.Size(603, 348);
            this.dgvDavomat.TabIndex = 0;
            this.dgvDavomat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDavomat_CellContentClick);
            // 
            // cmbGuruhlar
            // 
            this.cmbGuruhlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbGuruhlar.FormattingEnabled = true;
            this.cmbGuruhlar.Location = new System.Drawing.Point(423, 417);
            this.cmbGuruhlar.Name = "cmbGuruhlar";
            this.cmbGuruhlar.Size = new System.Drawing.Size(121, 28);
            this.cmbGuruhlar.TabIndex = 1;
            this.cmbGuruhlar.SelectedIndexChanged += new System.EventHandler(this.cmbGuruhlar_SelectedIndexChanged);
            // 
            // btnSaqlash
            // 
            this.btnSaqlash.BackColor = System.Drawing.Color.Bisque;
            this.btnSaqlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaqlash.Location = new System.Drawing.Point(713, 415);
            this.btnSaqlash.Name = "btnSaqlash";
            this.btnSaqlash.Size = new System.Drawing.Size(75, 30);
            this.btnSaqlash.TabIndex = 2;
            this.btnSaqlash.Text = "Saqlash";
            this.btnSaqlash.UseVisualStyleBackColor = false;
            this.btnSaqlash.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbFanlar
            // 
            this.cmbFanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbFanlar.FormattingEnabled = true;
            this.cmbFanlar.Location = new System.Drawing.Point(561, 417);
            this.cmbFanlar.Name = "cmbFanlar";
            this.cmbFanlar.Size = new System.Drawing.Size(121, 28);
            this.cmbFanlar.TabIndex = 3;
            this.cmbFanlar.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "O\'quvchilarni nazorat qilish jadvali";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblIsm);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 394);
            this.panel2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Bisque;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(33, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 39);
            this.button3.TabIndex = 6;
            this.button3.Text = "Xabarlar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(33, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sozlash";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(33, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Chiqish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblIsm
            // 
            this.lblIsm.AutoSize = true;
            this.lblIsm.Location = new System.Drawing.Point(43, 72);
            this.lblIsm.Name = "lblIsm";
            this.lblIsm.Size = new System.Drawing.Size(70, 13);
            this.lblIsm.TabIndex = 2;
            this.lblIsm.Text = "Uqtuvchi ismi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KURSISHI_11.Properties.Resources._240_F_229758328_7x8jwCwjtBMmC6rgFzLFhZoEpLobB6L8;
            this.pictureBox1.Location = new System.Drawing.Point(46, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UqtuvchiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbFanlar);
            this.Controls.Add(this.btnSaqlash);
            this.Controls.Add(this.cmbGuruhlar);
            this.Controls.Add(this.dgvDavomat);
            this.Name = "UqtuvchiForm";
            this.Text = "UqtuvchiForm";
            this.Load += new System.EventHandler(this.UqtuvchiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDavomat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDavomat;
        private System.Windows.Forms.ComboBox cmbGuruhlar;
        private System.Windows.Forms.Button btnSaqlash;
        private System.Windows.Forms.ComboBox cmbFanlar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIsm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}