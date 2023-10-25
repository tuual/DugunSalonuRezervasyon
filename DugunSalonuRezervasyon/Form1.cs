namespace DugunSalonuRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            if (txtUyeNo.TextLength <= 0 && txtSifre.TextLength <= 0)
            {
                lbInfo.Visible = true;
            }
            else
            {
                lbInfo.Visible = true;
                lbInfo.Text = "Giriþ Baþarýlý ";
                lbInfo.ForeColor = Color.Green;
                lbInfo.Location = new Point(91, 0);

            }
        }
    }
}