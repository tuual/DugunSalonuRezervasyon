using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DugunSalonuRezervasyon
{
    public partial class frmUyeOlusturma : Form
    {
        private MySqlCommand cmd;
        private MySqlConnection con;
        public frmUyeOlusturma()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost; Database=DugunRezervasyon; Uid=root; Pwd=''");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Random rnd = new Random();
                String harfler = "ABCDEFGHIJKLMNOPRSTUVYZabcdefghijklmnoprstuvyz";
                int sayi;
                String rastgele = "";
                for (int i = 0; i < 2; i++)
                {
                    rastgele += harfler[rnd.Next(harfler.Length)];
                    sayi = rnd.Next(0, 10);
                    txtUyeSifre.Text = rastgele + sayi;
                }

            }
            else
            {
                txtUyeSifre.Text = "";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtUyeAdi.Text == "" && txtUyeNo.Text == "" && txtUyeSifre.Text == "")
            {
                lbInfo.Visible = true;
                lbInfo.ForeColor = Color.Red;
                lbInfo.Text = "Boş Bırakılamaz";

            }
            else
            {
                InsertSql();
             
            }
        }
        private void InsertSql()
        {
            String query = "INSERT INTO uyeler(uyeAdi,uyeNo,uyeSifre) VALUES (@uyeadi,@uyeno,@uyesifre)";

            try
            {
                cmd = new MySqlCommand(query, con);
                con.Open();
                if (txtUyeAdi.Text == "" || txtUyeNo.Text == "" || txtUyeSifre.Text == "")
                {
                    lbInfo.Visible = true;
                    lbInfo.ForeColor = Color.Red;
                    lbInfo.Text = "Ekleme Başarısız";
                }
                else
                {
                    cmd.Parameters.AddWithValue("@uyeadi", txtUyeAdi.Text);
                    cmd.Parameters.AddWithValue("@uyeno", txtUyeNo.Text);
                    cmd.Parameters.AddWithValue("@uyesifre", txtUyeSifre.Text);
                    cmd.ExecuteNonQuery();
                    txtUyeSifre.Text = "";
                    txtUyeNo.Text = "";
                    txtUyeAdi.Text = "";
                    lbInfo.Visible = true;
                    lbInfo.ForeColor = Color.Green;
                    lbInfo.Text = "Ekleme Başarılı";
                   
                }
                

                
            }catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
