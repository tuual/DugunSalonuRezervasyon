namespace DugunSalonuRezervasyon
{
    partial class frmUyeListe
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnKaydet = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
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
            panel3.Size = new Size(1110, 76);
            panel3.TabIndex = 14;
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
            label1.Location = new Point(363, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 54);
            label1.TabIndex = 1;
            label1.Text = "Üyeleri Listeleme";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1110, 466);
            dataGridView1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnKaydet);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(957, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 466);
            panel1.TabIndex = 16;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.IndianRed;
            btnKaydet.FlatStyle = FlatStyle.Popup;
            btnKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(16, 60);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(125, 50);
            btnKaydet.TabIndex = 16;
            btnKaydet.Text = "Güncelle";
            btnKaydet.UseVisualStyleBackColor = false;
            // 
            // frmUyeListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 542);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmUyeListe";
            Load += frmUyeListe_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
        private Button btnKaydet;
    }
}