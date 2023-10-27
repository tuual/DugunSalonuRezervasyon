using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DugunSalonuRezervasyon
{
    public partial class frmUyeListe : Form
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        public frmUyeListe()
        {
            InitializeComponent();
        }

        private void frmUyeListe_Load(object sender, EventArgs e)
        {
            tableUpdate();
        }
        private void tableUpdate()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;




            string readQuery = "SELECT * FROM uyeler";
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
         if(e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
            DataGridViewRow selectRow = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectRow.Cells["ID"].Value);
                String query = "Delete From uyeler WHERE ID=" + id;
                DialogResult dr = MessageBox.Show("Üyeyi Silmek İstiyor musunuz ?", "Sistem",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
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
    }
}
