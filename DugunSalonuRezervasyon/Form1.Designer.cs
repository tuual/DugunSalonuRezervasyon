namespace DugunSalonuRezervasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txtUyeNo = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            lbInfo = new Label();
            button1 = new Button();
            txtSifre = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(188, 52);
            label1.Name = "label1";
            label1.Size = new Size(418, 41);
            label1.TabIndex = 0;
            label1.Text = "Düğün Salonu Rezervasyonu";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 163);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(335, 108);
            label2.Name = "label2";
            label2.Size = new Size(113, 31);
            label2.TabIndex = 0;
            label2.Text = "Üye Girişi";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtUyeNo
            // 
            txtUyeNo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUyeNo.Location = new Point(256, 41);
            txtUyeNo.Multiline = true;
            txtUyeNo.Name = "txtUyeNo";
            txtUyeNo.PlaceholderText = "Üye No";
            txtUyeNo.Size = new Size(268, 37);
            txtUyeNo.TabIndex = 0;
            txtUyeNo.TextAlign = HorizontalAlignment.Center;
            txtUyeNo.TextChanged += txtUyeNo_TextChanged;
            txtUyeNo.KeyPress += txtUyeNo_KeyPress;
            txtUyeNo.MouseHover += txtUyeNo_MouseHover;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtSifre);
            panel2.Controls.Add(txtUyeNo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 287);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbInfo);
            panel3.Location = new Point(256, 161);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 33);
            panel3.TabIndex = 4;
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbInfo.ForeColor = Color.Red;
            lbInfo.Location = new Point(8, 0);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(260, 23);
            lbInfo.TabIndex = 3;
            lbInfo.Text = "Üye No ve Şifre boş bırakılamaz !";
            lbInfo.TextAlign = ContentAlignment.MiddleCenter;
            lbInfo.Visible = false;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.FromArgb(26, 35, 126);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            button1.FlatAppearance.BorderSize = 8;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.FromArgb(197, 202, 233);
            button1.Location = new Point(298, 198);
            button1.Name = "button1";
            button1.Size = new Size(184, 39);
            button1.TabIndex = 2;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(256, 117);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.PlaceholderText = "Şifre";
            txtSifre.Size = new Size(268, 38);
            txtSifre.TabIndex = 1;
            txtSifre.TextAlign = HorizontalAlignment.Center;
            txtSifre.TextChanged += txtUyeNo_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtUyeNo;
        private Panel panel2;
        private Button button1;
        private TextBox txtSifre;
        private Label label2;
        private Label lbInfo;
        private Panel panel3;
    }
}