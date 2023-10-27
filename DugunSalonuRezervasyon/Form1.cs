using MySql.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;

namespace DugunSalonuRezervasyon
{
    public partial class Form1 : Form
    {
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private MySqlConnection con;
        public String adisutun = "";

        public Form1()
        {
            InitializeComponent();

            con = new MySqlConnection("Server=localhost; Database=DugunRezervasyon; Uid=root; Pwd=''");
        }

        private void txtUyeNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUyeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtUyeNo_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.Active = true;
            tp.SetToolTip(this.txtUyeNo, "Sadece Sayý Giriþi Yapýlabilir");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUyeNo.TextLength <= 0 || txtSifre.TextLength <= 0)
            {


                lbInfo.Visible = true;
            }
            else
            {
                lbInfo.Visible = true;
                lbInfo.Text = "Giriþ Baþarýlý ";
                lbInfo.ForeColor = Color.Green;
                lbInfo.Location = new Point(91, 0);

                String uyeno = txtUyeNo.Text;
                String uyesifre = txtSifre.Text;
                //-- Giriþ Kodlarý --//
                sqlId();
                loginCheck(uyeno, uyesifre);

            }
        }

        private void loginCheck(String uyeno, String uyesifre)
        {
            String query = "SELECT * FROM uyeler where uyeNo=@uyeno AND uyesifre=@uyeSifre";
            try
            {
                cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@uyeno", uyeno);
                cmd.Parameters.AddWithValue("@uyesifre", uyesifre);
                
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (txtUyeNo.Text.Equals("982") || txtSifre.Text.Equals("99admin"))
                    {
                        frmAdminPanel frmadmin = new frmAdminPanel();
                        frmadmin.Show();
                        this.Hide();
                        con.Close();

                    }
                    else
                    {
                        frmAnaEkran frmana = new frmAnaEkran(adisutun);
                        frmana.Show();
                        this.Hide();
                        con.Close();
                    }

                }
                else
                {
                    lbInfo.ForeColor = Color.Red;
                    lbInfo.Text = "Bilgiler hatalý !";
                    lbInfo.Location = new Point(77, 0);
                    con.Close();

                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                con.Close();

            }


        }
        private void sqlId()
        {
            try
            {
                String query2 = "SELECT * FROM uyeler where uyeNo=@uyenoo";
                con.Open();
                cmd = new MySqlCommand(query2, con);
                cmd.Parameters.AddWithValue("@uyenoo", txtUyeNo.Text);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        adisutun = reader.GetString(1);
                    }

                    
                }
                else
                {
                    con.Close();
                }
                con.Close();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
           
        }
    }
}