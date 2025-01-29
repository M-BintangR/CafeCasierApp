namespace CafeCasierApp
{
    public partial class KasirPanelForm : Form
    {
        public KasirPanelForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnPelanggan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PelangganForm().Show();
        }

        private void btnPesanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PesananForm().Show();
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PembayaranForm().Show();
        }
    }
}
