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
    public partial class frmAnaEkran : Form
    {
        private Form1 frm1;
        public frmAnaEkran(string veri)
        {
            InitializeComponent();
            frm1 = new Form1();
            lbIsim.Text = veri;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            MessageBox.Show(frm1.adisutun);
            lbIsim.Visible = true;
        }
    }
}
