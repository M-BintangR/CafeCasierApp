namespace CafeCasierApp
{
    public partial class LoginForm : Form
    {
        private string email, password;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            this.email = txtEmail.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.password = txtPassword.Text;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(this.email, this.password);

            if (login.VerifyLogin())
            {
                MessageBox.Show("Anda berhasil login!", "Berhasil");
            }
            else
            {
                MessageBox.Show("Ada yang salah, anda tidak dapat login, cek kembali password & email anda", "Pesan kesalahan");
                new LoginForm().Show();
            }

            this.Hide();
        }
    }
}
