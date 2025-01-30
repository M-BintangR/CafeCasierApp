using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace CafeCasierApp
{
    public partial class PenggunaForm : Form
    {
        private readonly Koneksi koneksi;
        private DataTable dataTable;
        private string email, password, username, role;
        public PenggunaForm()
        {
            InitializeComponent();
            koneksi = new Koneksi();
            LoadDataPengguna();

            this.cmbPeran.Items.Clear();
            this.cmbPeran.Items.Add("admin");
            this.cmbPeran.Items.Add("kasir");
            this.cmbPeran.SelectedIndex = 0;

            this.btnTambah.Visible = true;
            this.btnEdit.Visible = false;
            this.btnHapus.Visible = false;
        }

        public void LoadDataPengguna()
        {
            try
            {
                koneksi.openConnection();

                string query = "SELECT * FROM users";
                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        tableData.DataSource = dataTable; // Menampilkan data di DataGridView
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal memuat data pengguna: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanelForm().Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            this.email = txtEmail.Text;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            this.username = txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.password = txtPassword.Text;
        }

        private void cmbPeran_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.role = cmbPeran.Text;
        }

        private void resetData()
        {
            LoadDataPengguna();

            this.username = "";
            this.email = "";
            this.password = "";
            this.role = "";

            txtEmail.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            cmbPeran.SelectedIndex = 0;

            this.btnTambah.Visible = true;
            this.btnEdit.Visible = false;
            this.btnHapus.Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();
                string query = "INSERT INTO users (email, password, username, role) VALUES (@Email, @Password, @Username, @Role)";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Role", role);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pengguna berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan pengguna!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal menambah pengguna: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }
    }
}
