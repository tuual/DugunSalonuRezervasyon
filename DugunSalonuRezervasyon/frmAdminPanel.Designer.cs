namespace DugunSalonuRezervasyon
{
    partial class frmAdminPanel
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
            menuStrip1 = new MenuStrip();
            üyeOluşturmaToolStripMenuItem = new ToolStripMenuItem();
            üyeleriGörüntüleToolStripMenuItem = new ToolStripMenuItem();
            üyeEkleToolStripMenuItem = new ToolStripMenuItem();
            rezervasyonlarToolStripMenuItem = new ToolStripMenuItem();
            rezervasyonlarıGörüntüleToolStripMenuItem = new ToolStripMenuItem();
            rezervasyonOluştuToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { üyeOluşturmaToolStripMenuItem, rezervasyonlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1102, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // üyeOluşturmaToolStripMenuItem
            // 
            üyeOluşturmaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { üyeleriGörüntüleToolStripMenuItem, üyeEkleToolStripMenuItem });
            üyeOluşturmaToolStripMenuItem.Image = Properties.Resources.add_user;
            üyeOluşturmaToolStripMenuItem.Name = "üyeOluşturmaToolStripMenuItem";
            üyeOluşturmaToolStripMenuItem.Size = new Size(140, 24);
            üyeOluşturmaToolStripMenuItem.Text = "Üye Oluşturma";
            // 
            // üyeleriGörüntüleToolStripMenuItem
            // 
            üyeleriGörüntüleToolStripMenuItem.Name = "üyeleriGörüntüleToolStripMenuItem";
            üyeleriGörüntüleToolStripMenuItem.Size = new Size(224, 26);
            üyeleriGörüntüleToolStripMenuItem.Text = "Üyeleri Görüntüle";
            üyeleriGörüntüleToolStripMenuItem.Click += üyeleriGörüntüleToolStripMenuItem_Click;
            // 
            // üyeEkleToolStripMenuItem
            // 
            üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            üyeEkleToolStripMenuItem.Size = new Size(224, 26);
            üyeEkleToolStripMenuItem.Text = "Üye Ekle";
            üyeEkleToolStripMenuItem.Click += üyeEkleToolStripMenuItem_Click;
            // 
            // rezervasyonlarToolStripMenuItem
            // 
            rezervasyonlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rezervasyonlarıGörüntüleToolStripMenuItem, rezervasyonOluştuToolStripMenuItem });
            rezervasyonlarToolStripMenuItem.Image = Properties.Resources.notes;
            rezervasyonlarToolStripMenuItem.Name = "rezervasyonlarToolStripMenuItem";
            rezervasyonlarToolStripMenuItem.Size = new Size(125, 24);
            rezervasyonlarToolStripMenuItem.Text = "Rezervasyon";
            rezervasyonlarToolStripMenuItem.Click += rezervasyonlarToolStripMenuItem_Click;
            // 
            // rezervasyonlarıGörüntüleToolStripMenuItem
            // 
            rezervasyonlarıGörüntüleToolStripMenuItem.Name = "rezervasyonlarıGörüntüleToolStripMenuItem";
            rezervasyonlarıGörüntüleToolStripMenuItem.Size = new Size(264, 26);
            rezervasyonlarıGörüntüleToolStripMenuItem.Text = "Rezervasyonları Görüntüle";
            // 
            // rezervasyonOluştuToolStripMenuItem
            // 
            rezervasyonOluştuToolStripMenuItem.Name = "rezervasyonOluştuToolStripMenuItem";
            rezervasyonOluştuToolStripMenuItem.Size = new Size(264, 26);
            rezervasyonOluştuToolStripMenuItem.Text = "Rezervasyon oluştur";
            rezervasyonOluştuToolStripMenuItem.Click += rezervasyonOluştuToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(1102, 534);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 125);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(601, 32);
            label2.TabIndex = 1;
            label2.Text = "Menü panelinden işlemlerinizi kolaylıkla yapabilirsiniz.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(921, 41);
            label1.TabIndex = 0;
            label1.Text = "Düğün Salonu Rezervasyon Programı Admin Paneline Hoşgeldiniz";
            // 
            // frmAdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 562);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            ImeMode = ImeMode.Disable;
            MainMenuStrip = menuStrip1;
            Name = "frmAdminPanel";
            Load += frmAdminPanel_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem üyeOluşturmaToolStripMenuItem;
        private ToolStripMenuItem üyeleriGörüntüleToolStripMenuItem;
        private ToolStripMenuItem üyeEkleToolStripMenuItem;
        private ToolStripMenuItem rezervasyonlarToolStripMenuItem;
        private ToolStripMenuItem rezervasyonlarıGörüntüleToolStripMenuItem;
        private ToolStripMenuItem rezervasyonOluştuToolStripMenuItem;
        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}