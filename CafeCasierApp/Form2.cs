namespace CafeCasierApp
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PenggunaForm().Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MenuForm().Show();
            
        }
    }
}
