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
    public partial class frmUyeListe : Form
    {
        private SqlConnection con;
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
            con = new SqlConnection("Server=DESKTOP-LRUAD0T;Database=DugunRezervasyon;User Id=biltekbilisim;Password=Bilisim20037816;");
          
                using (SqlDataAdapter adapter = new SqlDataAdapter(readQuery, con))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // DataGridView kontrolüne verileri yükle
                    dataGridView1.DataSource = dataTable;
                }


            
        }
    }
}
