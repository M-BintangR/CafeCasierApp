﻿using MySql.Data.MySqlClient;
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

            this.btnTambah.Enabled = true;
            this.btnEdit.Enabled = false;
            this.btnHapus.Enabled = false;
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
                        tableData.DataSource = dataTable;
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

            this.btnTambah.Enabled = true;
            this.btnEdit.Enabled = false;
            this.btnHapus.Enabled = false;
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

        private void tableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btnTambah.Enabled = false;
            this.btnEdit.Enabled = true;
            this.btnHapus.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tableData.Rows[e.RowIndex];

                this.email = row.Cells["email"].Value.ToString() ?? "";
                this.username = row.Cells["username"].Value.ToString() ?? "";
                this.role = row.Cells["role"].Value.ToString() ?? "";

                txtEmail.Text = this.email;
                txtUsername.Text = this.username;
                cmbPeran.SelectedItem = this.role;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Pilih pengguna yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Apakah Anda yakin ingin menghapus pengguna {username}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    koneksi.openConnection();
                    string query = "DELETE FROM users WHERE email = @Email";

                    using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pengguna berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus pengguna!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Gagal menghapus pengguna: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine($"Error: {err.Message}");
                }
                finally
                {
                    koneksi.CloseConnection();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Email dan Username tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();

                string query;
                if (!string.IsNullOrWhiteSpace(password))
                {
                    query = "UPDATE users SET username = @Username, role = @Role, password = @Password WHERE email = @Email";
                }
                else
                {
                    query = "UPDATE users SET username = @Username, role = @Role WHERE email = @Email";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Role", role);

                    if (!string.IsNullOrWhiteSpace(password))
                    {
                        cmd.Parameters.AddWithValue("@Password", password);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pengguna berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui pengguna!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal memperbarui pengguna: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }
    }
}
