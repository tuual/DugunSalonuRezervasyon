namespace DugunSalonuRezervasyon
{
    partial class frmUyeOlusturma
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
            panel1 = new Panel();
            panel3 = new Panel();
            lbInfo = new Label();
            btnKaydet = new Button();
            checkBox1 = new CheckBox();
            label5 = new Label();
            txtUyeSifre = new TextBox();
            label4 = new Label();
            txtUyeNo = new TextBox();
            label3 = new Label();
            txtUyeAdi = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtUyeSifre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtUyeNo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUyeAdi);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 513);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbInfo);
            panel3.Location = new Point(316, 355);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 33);
            panel3.TabIndex = 17;
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbInfo.ForeColor = Color.Red;
            lbInfo.Location = new Point(73, 6);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(128, 23);
            lbInfo.TabIndex = 3;
            lbInfo.Text = "Boş Bırakılamaz";
            lbInfo.TextAlign = ContentAlignment.MiddleCenter;
            lbInfo.Visible = false;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.IndianRed;
            btnKaydet.FlatStyle = FlatStyle.Popup;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(358, 394);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(197, 50);
            btnKaydet.TabIndex = 16;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(358, 334);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Rastgele Şifre";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(358, 271);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 10;
            label5.Text = "Üye Şifre: ";
            // 
            // txtUyeSifre
            // 
            txtUyeSifre.Location = new Point(358, 294);
            txtUyeSifre.Multiline = true;
            txtUyeSifre.Name = "txtUyeSifre";
            txtUyeSifre.Size = new Size(197, 34);
            txtUyeSifre.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(358, 194);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 8;
            label4.Text = "Üye Numarası: ";
            // 
            // txtUyeNo
            // 
            txtUyeNo.Location = new Point(358, 217);
            txtUyeNo.Multiline = true;
            txtUyeNo.Name = "txtUyeNo";
            txtUyeNo.Size = new Size(197, 34);
            txtUyeNo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(358, 104);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 6;
            label3.Text = "Üye Adı: ";
            // 
            // txtUyeAdi
            // 
            txtUyeAdi.Location = new Point(358, 127);
            txtUyeAdi.Multiline = true;
            txtUyeAdi.Name = "txtUyeAdi";
            txtUyeAdi.Size = new Size(197, 34);
            txtUyeAdi.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(698, 481);
            label2.Name = "label2";
            label2.Size = new Size(345, 23);
            label2.TabIndex = 1;
            label2.Text = "Üyeyi ekledikten sonra bu sayfayı kapatınız.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1055, 81);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(251, 46);
            label1.TabIndex = 0;
            label1.Text = "Üye Oluşturma";
            // 
            // frmUyeOlusturma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 513);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmUyeOlusturma";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private CheckBox checkBox1;
        private Label label5;
        private TextBox txtUyeSifre;
        private Label label4;
        private TextBox txtUyeNo;
        private Label label3;
        private TextBox txtUyeAdi;
        private Button btnKaydet;
        private Panel panel3;
        private Label lbInfo;
    }
}