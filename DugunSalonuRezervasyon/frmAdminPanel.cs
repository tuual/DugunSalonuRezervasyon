using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DugunSalonuRezervasyon
{
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
        }

        private void rezervasyonOluştuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rezervasyonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void üyeOluşturmaToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void üyeOluşturmaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
        }



        private void frmAdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void üyeleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUyeListe frmuyelist = new frmUyeListe();
            frmuyelist.Show();
        }

        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUyeOlusturma frmuyeolusturma = new frmUyeOlusturma();
            frmuyeolusturma.Show();
        }

        private void rezervasyonlarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRezervasyonlar frmrez = new frmRezervasyonlar();
            frmrez.Show();
            
        }
    }
}
