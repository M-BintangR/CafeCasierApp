using MySql.Data.MySqlClient;
using System.Data;

namespace CafeCasierApp
{
    public partial class MenuForm : Form
    {
        private readonly Koneksi koneksi;
        private DataTable dataTable;
        private string nameMenu, price, description, idMenu;
        public MenuForm()
        {
            InitializeComponent();
            koneksi = new Koneksi();
            LoadDataMenu();

            this.btnTambah.Enabled = true;
            this.btnEdit.Enabled = false;
            this.btnHapus.Enabled = false;
        }

        private void LoadDataMenu()
        {
            try
            {
                koneksi.openConnection();

                string query = "SELECT * FROM menu";
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
                MessageBox.Show($"Gagal memuat data menu: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void resetData()
        {
            LoadDataMenu();

            this.nameMenu = "";
            this.price = "";
            this.description = "";
            this.idMenu = "";

            txtHarga.Text = "";
            txtNamaMenu.Text = "";
            txtKeterangan.Text = "";

            this.btnTambah.Enabled = true;
            this.btnEdit.Enabled = false;
            this.btnHapus.Enabled = false;
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

        private void txtNamaMenu_TextChanged(object sender, EventArgs e)
        {
            this.nameMenu = txtNamaMenu.Text;
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            this.price = txtHarga.Text;
        }

        private void txtKeterangan_TextChanged(object sender, EventArgs e)
        {
            this.description = txtKeterangan.Text;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(nameMenu) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();
                string query = "INSERT INTO menu (nama, harga, deskripsi) VALUES (@Nama, @Harga, @Deskripsi)";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Nama", this.nameMenu);
                    cmd.Parameters.AddWithValue("@Harga", this.price);
                    cmd.Parameters.AddWithValue("@Deskripsi", this.description);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Menu berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan menu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal menambah menu: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                this.nameMenu = row.Cells["nama"].Value.ToString() ?? "";
                this.price = row.Cells["harga"].Value.ToString() ?? "";
                this.description = row.Cells["deskripsi"].Value.ToString() ?? "";
                this.idMenu = row.Cells["id_menu"].Value.ToString() ?? "";

                txtNamaMenu.Text = this.nameMenu;
                txtHarga.Text = this.price;
                txtKeterangan.Text = this.description;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.nameMenu))
            {
                MessageBox.Show("Pilih menu yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Apakah Anda yakin ingin menghapus menu {this.nameMenu}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    koneksi.openConnection();
                    string query = "DELETE FROM menu WHERE id_menu = @IdMenu";

                    using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@IdMenu", this.idMenu);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Menu berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus menu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Gagal menghapus menu: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrWhiteSpace(this.nameMenu) || string.IsNullOrWhiteSpace(this.price) || string.IsNullOrWhiteSpace(this.description))
            {
                MessageBox.Show("Data yang di inputkan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();

                string query = "UPDATE menu SET nama = @NamaMenu, harga = @Harga, deskripsi = @Deskripsi WHERE id_menu = @IdMenu";
               

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@NamaMenu", this.nameMenu);
                    cmd.Parameters.AddWithValue("@Harga", this.price);
                    cmd.Parameters.AddWithValue("@Deskripsi", this.description);
                    cmd.Parameters.AddWithValue("@IdMenu", this.idMenu);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Menu berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui menu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal memperbarui menu: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }
    }
}
