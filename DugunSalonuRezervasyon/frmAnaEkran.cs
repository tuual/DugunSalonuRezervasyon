using MySql.Data.MySqlClient;
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
        private MySqlCommand cmd;
        private MySqlConnection con;
        public frmAnaEkran(string veri)
        {
            InitializeComponent();
            frm1 = new Form1();
            lbIsim.Text = veri;
            con = new MySqlConnection("Server=localhost; Database=DugunRezervasyon; Uid=root; Pwd=''");

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            MessageBox.Show(frm1.adisutun);
            lbIsim.Visible = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            String query = "INSERT INTO rezervasyonlar(adi,soyadi,kisisayisi,rezTuru,yemek,icecek,rezTarih) VALUES (@adi,@soyadi,@kisisayisi,@rezTuru,@yemek,@icecek,@rezTarih)";


            cmd = new MySqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@adi", textBox2.Text);
            cmd.Parameters.AddWithValue("@soyadi", textBox3.Text);
            cmd.Parameters.AddWithValue("@kisisayisi", textBox4.Text);
            cmd.Parameters.AddWithValue("@rezTuru", comboBox1.Text);
            cmd.Parameters.AddWithValue("@yemek", comboBox2.Text);
            cmd.Parameters.AddWithValue("@icecek", comboBox3.Text);
            cmd.Parameters.AddWithValue("@rezTarih", dateTimePicker1.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Eklendi.");






        }


    }

}
