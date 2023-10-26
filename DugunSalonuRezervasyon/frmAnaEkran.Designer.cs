namespace DugunSalonuRezervasyon
{
    partial class frmAnaEkran
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
            label1 = new Label();
            panel1 = new Panel();
            lbIsim = new Label();
            label10 = new Label();
            panel2 = new Panel();
            btnKaydet = new Button();
            label12 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            comboBox3 = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(448, 54);
            label1.TabIndex = 0;
            label1.Text = "Rezervasyon Oluşturma";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(lbIsim);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1066, 70);
            panel1.TabIndex = 1;
            // 
            // lbIsim
            // 
            lbIsim.AutoSize = true;
            lbIsim.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbIsim.ForeColor = Color.White;
            lbIsim.Location = new Point(938, 29);
            lbIsim.Name = "lbIsim";
            lbIsim.Size = new Size(27, 28);
            lbIsim.TabIndex = 2;
            lbIsim.Text = "...";
            lbIsim.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(802, 29);
            label10.Name = "label10";
            label10.Size = new Size(130, 28);
            label10.TabIndex = 1;
            label10.Text = "Hoşgeldiniz :";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnKaydet);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1066, 514);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.IndianRed;
            btnKaydet.FlatStyle = FlatStyle.Popup;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(487, 301);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(197, 57);
            btnKaydet.TabIndex = 15;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(668, 438);
            label12.Name = "label12";
            label12.Size = new Size(386, 23);
            label12.TabIndex = 14;
            label12.Text = "Bilgi: Kırmızı Olanlar Dolu Rezervasyon Tarihleridir";
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 476);
            panel3.Name = "panel3";
            panel3.Size = new Size(1066, 38);
            panel3.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(483, 201);
            label9.Name = "label9";
            label9.Size = new Size(133, 20);
            label9.TabIndex = 12;
            label9.Text = "Rezervasyon Tarihi:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(483, 224);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(487, 125);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 10;
            label8.Text = "İçecekli-İçeceksiz: ";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "İçecekli", "İçeceksiz" });
            comboBox3.Location = new Point(487, 148);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(197, 28);
            comboBox3.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(487, 50);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 8;
            label7.Text = "Yemekli-Yemeksiz:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Yemekli", "Yemeksiz" });
            comboBox2.Location = new Point(487, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(197, 28);
            comboBox2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(163, 288);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 6;
            label6.Text = "Rezervasyon Türü: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Düğün", "Nişan", "Kına", "Eğlence" });
            comboBox1.Location = new Point(163, 311);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 28);
            comboBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(163, 201);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Kişi Sayısı: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(163, 125);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 4;
            label4.Text = "Soyadınız: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(163, 50);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 4;
            label3.Text = "Adınız: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(163, 224);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(197, 34);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 148);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 34);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 73);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 34);
            textBox2.TabIndex = 0;
            // 
            // frmAnaEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1066, 584);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmAnaEkran_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private ComboBox comboBox3;
        private Label label7;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lbIsim;
        private Label label10;
        private Panel panel3;
        private Label label9;
        private Button btnKaydet;
        private Label label12;
    }
}