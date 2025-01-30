using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeCasierApp
{
    public partial class PelangganForm : Form
    {
        private readonly Koneksi koneksi;
        private DataTable dataTable;
        private string nameCustomer, tableNumber, floorNumber, idPelanggan;
        public PelangganForm()
        {
            InitializeComponent();
            koneksi = new Koneksi();
            LoadDataPelanggan();

            this.btnTambah.Enabled = true;
            this.btnEdit.Enabled = false;
            this.btnHapus.Enabled = false;
        }

        private void LoadDataPelanggan()
        {
            try
            {
                koneksi.openConnection();

                string query = "SELECT id_pesanan AS id_pelanggan, nama_pelanggan, nomor_meja, nomor_lantai  FROM pesanan";
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
                MessageBox.Show($"Gagal memuat data pelanggan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void resetData()
        {
            LoadDataPelanggan();

            this.nameCustomer = "";
            this.floorNumber = "";
            this.tableNumber = "";

            txtNomorLantai.Text = "";
            txtNamaPelanggan.Text = "";
            txtNomorMeja.Text = "";

            this.btnTambah.Enabled = true;
            this.btnEdit.Enabled = false;
            this.btnHapus.Enabled = false;
        } 

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new KasirPanelForm().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void txtNamaPelanggan_TextChanged(object sender, EventArgs e)
        {
            this.nameCustomer = txtNamaPelanggan.Text;
        }

        private void txtNomorMeja_TextChanged(object sender, EventArgs e)
        {
            this.tableNumber = txtNomorMeja.Text;
        }

        private void txtNomorLantai_TextChanged(object sender, EventArgs e)
        {
            this.floorNumber = txtNomorLantai.Text;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameCustomer) || string.IsNullOrWhiteSpace(tableNumber) || string.IsNullOrWhiteSpace(floorNumber))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();
                string query = "INSERT INTO pesanan (nama_pelanggan, nomor_meja, nomor_lantai) VALUES (@Nama, @Meja, @Lantai)";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Nama", nameCustomer);
                    cmd.Parameters.AddWithValue("@Meja", tableNumber);
                    cmd.Parameters.AddWithValue("@Lantai", floorNumber);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pelanggan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan pelanggan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal menambah pelanggan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idPelanggan))
            {
                MessageBox.Show("Pilih pelanggan yang akan diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();
                string query = "UPDATE pesanan SET nama_pelanggan = @Nama, nomor_meja = @Meja, nomor_lantai = @Lantai WHERE id_pesanan = @ID";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Nama", nameCustomer);
                    cmd.Parameters.AddWithValue("@Meja", tableNumber);
                    cmd.Parameters.AddWithValue("@Lantai", floorNumber);
                    cmd.Parameters.AddWithValue("@ID", idPelanggan);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data pelanggan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui data pelanggan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal memperbarui pelanggan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idPelanggan))
            {
                MessageBox.Show("Pilih pelanggan yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus pelanggan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                koneksi.openConnection();
                string query = "DELETE FROM pesanan WHERE id_pesanan = @ID";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@ID", idPelanggan);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data pelanggan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus pelanggan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal menghapus pelanggan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                this.nameCustomer = row.Cells["nama_pelanggan"].Value.ToString() ?? "";
                this.floorNumber = row.Cells["nomor_lantai"].Value.ToString() ?? "";
                this.tableNumber = row.Cells["nomor_meja"].Value.ToString() ?? "";
                this.idPelanggan = row.Cells["id_pelanggan"].Value.ToString() ?? "";

                txtNamaPelanggan.Text = this.nameCustomer;
                txtNomorLantai.Text = this.floorNumber;
                txtNomorMeja.Text = this.tableNumber;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            resetData();
        }
    }
}
