using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DugunSalonuRezervasyon
{
    public partial class frmRezervasyonlar : Form
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        int id;
        public frmRezervasyonlar()
        {
            InitializeComponent();

        }



        private void tableUpdate()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;




            string readQuery = "SELECT * FROM rezervasyonlar";
            con = new MySqlConnection("Server=localhost; Database=DugunRezervasyon; Uid=root; Pwd=''");

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(readQuery, con))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // DataGridView kontrolüne verileri yükle
                dataGridView1.DataSource = dataTable;
            }



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectRow = dataGridView1.Rows[e.RowIndex];
                 id = Convert.ToInt32(selectRow.Cells["ID"].Value);
                String query = "Delete From rezervasyonlar WHERE ID=" + id;
                DialogResult dr = MessageBox.Show("Rezervasyonu Silmek İstiyor musunuz ?", "Sistem", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                switch (dr)
                {
                    case DialogResult.Yes:
                        con.Open();
                        cmd = new MySqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seçili Üye Silindi");
                        con.Close();
                        tableUpdate();
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        MessageBox.Show("Bilinmeyen Bir Hata Oluştu");
                        break;

                }

            }
        }

        private void frmRezervasyonlar_Load(object sender, EventArgs e)
        {
            tableUpdate();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
               String updateQuery = "UPDATE rezervasyonlar set adi=@adi,soyadi=@soyadi,kisisayisi=@kisisayisi,rezTuru=@rezTuru,yemek=@yemek,icecek=@icecek WHERE ID=" + id;
                con.Open();
                cmd = new MySqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@adi", textBox2.Text);
                cmd.Parameters.AddWithValue("@soyadi", textBox3.Text);
                cmd.Parameters.AddWithValue("@kisisayisi", textBox4.Text);
                cmd.Parameters.AddWithValue("@rezTuru", comboBox1.Text);
                cmd.Parameters.AddWithValue("@yemek", comboBox2.Text);
                cmd.Parameters.AddWithValue("@icecek", comboBox3.Text);
                cmd.Parameters.AddWithValue("@rezTarih", dateTimePicker1.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Güncelleme Başarılı");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
