namespace DugunSalonuRezervasyon
{
    partial class frmRezervasyonlar
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
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btnKaydet = new Button();
            dataGridView1 = new DataGridView();
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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1137, 76);
            panel3.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(788, 32);
            label2.Name = "label2";
            label2.Size = new Size(310, 25);
            label2.TabIndex = 17;
            label2.Text = "Silmek İstediğiniz Veriye Tıklayınız.\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(242, 9);
            label1.Name = "label1";
            label1.Size = new Size(485, 54);
            label1.TabIndex = 1;
            label1.Text = "Rezervasyonları Listeleme";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(btnKaydet);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1137, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 618);
            panel1.TabIndex = 19;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.IndianRed;
            btnKaydet.FlatStyle = FlatStyle.Popup;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(259, 470);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(125, 50);
            btnKaydet.TabIndex = 16;
            btnKaydet.Text = "Güncelle";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1131, 536);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.DimGray;
            label9.Location = new Point(305, 288);
            label9.Name = "label9";
            label9.Size = new Size(133, 20);
            label9.TabIndex = 30;
            label9.Text = "Rezervasyon Tarihi:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(305, 311);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 27);
            dateTimePicker1.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(309, 212);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 28;
            label8.Text = "İçecekli-İçeceksiz: ";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "İçecekli", "İçeceksiz" });
            comboBox3.Location = new Point(309, 235);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(197, 28);
            comboBox3.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(309, 137);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 26;
            label7.Text = "Yemekli-Yemeksiz:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Yemekli", "Yemeksiz" });
            comboBox2.Location = new Point(309, 160);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(197, 28);
            comboBox2.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(16, 352);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 24;
            label6.Text = "Rezervasyon Türü: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Düğün", "Nişan", "Kına", "Eğlence" });
            comboBox1.Location = new Point(16, 375);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 28);
            comboBox1.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(16, 265);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 20;
            label5.Text = "Kişi Sayısı: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(16, 189);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 21;
            label4.Text = "Soyadınız: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(16, 114);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 22;
            label3.Text = "Adınız: ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(16, 288);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(197, 34);
            textBox4.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 212);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 34);
            textBox3.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 137);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 34);
            textBox2.TabIndex = 17;
            // 
            // frmRezervasyonlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1709, 618);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmRezervasyonlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezervasyonlar";
            Load += frmRezervasyonlar_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btnKaydet;
        private DataGridView dataGridView1;
        private Label label9;
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
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}