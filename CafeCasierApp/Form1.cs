using System.ComponentModel.DataAnnotations;

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
            if(this.email == "admin@gmail.com" && this.password == "adminadmin")
            {
                new AdminPanelForm().Show();
            }else if(this.email == "kasir@gmail.com" && this.password == "kasirkasir")
            {

            }
            else
            {
                MessageBox.Show("Ada yang salah : password atau email anda salah!", "Terjadi Kesalahan");
            }

            this.Hide();
        }
    }
}
