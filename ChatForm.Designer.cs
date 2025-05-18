namespace KURSISHI_11
{
    partial class ChatForm
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
            this.lstXabarlar = new System.Windows.Forms.ListBox();
            this.btnYuborish = new System.Windows.Forms.Button();
            this.txtXabar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstXabarlar
            // 
            this.lstXabarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstXabarlar.FormattingEnabled = true;
            this.lstXabarlar.ItemHeight = 16;
            this.lstXabarlar.Location = new System.Drawing.Point(57, 0);
            this.lstXabarlar.Name = "lstXabarlar";
            this.lstXabarlar.Size = new System.Drawing.Size(621, 372);
            this.lstXabarlar.TabIndex = 0;
            // 
            // btnYuborish
            // 
            this.btnYuborish.BackColor = System.Drawing.Color.Bisque;
            this.btnYuborish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYuborish.Location = new System.Drawing.Point(591, 385);
            this.btnYuborish.Name = "btnYuborish";
            this.btnYuborish.Size = new System.Drawing.Size(87, 30);
            this.btnYuborish.TabIndex = 1;
            this.btnYuborish.Text = "Yuborish";
            this.btnYuborish.UseVisualStyleBackColor = false;
            this.btnYuborish.Click += new System.EventHandler(this.btnYuborish_Click);
            // 
            // txtXabar
            // 
            this.txtXabar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtXabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtXabar.Location = new System.Drawing.Point(57, 387);
            this.txtXabar.Multiline = true;
            this.txtXabar.Name = "txtXabar";
            this.txtXabar.Size = new System.Drawing.Size(528, 26);
            this.txtXabar.TabIndex = 2;
            this.txtXabar.TextChanged += new System.EventHandler(this.txtXabar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 52);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(440, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xabarlar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(703, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Chiqish";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtXabar);
            this.panel2.Controls.Add(this.btnYuborish);
            this.panel2.Controls.Add(this.lstXabarlar);
            this.panel2.Location = new System.Drawing.Point(33, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 433);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstXabarlar;
        private System.Windows.Forms.Button btnYuborish;
        private System.Windows.Forms.TextBox txtXabar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}