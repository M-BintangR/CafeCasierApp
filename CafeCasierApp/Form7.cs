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
    public partial class PesananForm : Form
    {
        private readonly Koneksi koneksi;
        private DataTable dataTable;
        private string idMenu, idPelanggan, idDetailPesanan, totalOrder, totalPrice, price;
        public PesananForm()
        {
            InitializeComponent();
            koneksi = new Koneksi();
            LoadDataMenu();
            LoadDataPelanggan();

            this.btnTambah.Enabled = true;
            this.btnEdit.Enabled = false;
            this.btnHapus.Enabled = false;

            this.txtHarga.Enabled = false;
            this.txtTotalHarga.Enabled = false;

            txtTotalHarga.Text = "0";
            txtHarga.Text = "0";
            this.price = "0";
            this.totalPrice = "0";
        }

        private void resetData()
        {
            this.idMenu = "";
            this.idDetailPesanan = "";
            this.totalOrder = "";
            this.totalPrice = "";
            this.price = "";

            txtHarga.Text = "";
            txtJumlahPesanan.Text = "";
            txtTotalHarga.Text = "";

            cmbMenu.SelectedIndex = -1;

            this.btnTambah.Enabled = true;
            this.btnEdit.Enabled = false;
            this.btnHapus.Enabled = false;

            this.txtHarga.Enabled = false;
            this.txtTotalHarga.Enabled = false;

            txtTotalHarga.Text = "0";
            txtHarga.Text = "0";
            this.price = "0";
            this.totalPrice = "0";
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

                        cmbMenu.DataSource = dataTable;
                        cmbMenu.DisplayMember = "nama";  
                        cmbMenu.ValueMember = "id_menu";   
                        cmbMenu.SelectedIndex = -1;
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

        private void LoadDataPelanggan()
        {
            try
            {
                koneksi.openConnection();

                string query = "SELECT id_pesanan AS id_pelanggan, nama_pelanggan FROM pesanan";
                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbPelanggan.DataSource = dataTable;
                        cmbPelanggan.DisplayMember = "nama_pelanggan";
                        cmbPelanggan.ValueMember = "id_pelanggan";
                        cmbPelanggan.SelectedIndex = -1;
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

        private void LoadDataPesanan()
        {
            try
            {
                koneksi.openConnection();

                string query = @"SELECT menu.nama AS 'nama_pesanan', 
                        menu.harga AS 'harga', 
                        detail_pesanan.jml_pesanan AS 'jumlah',
                        detail_pesanan.total_harga AS 'total_harga',
                        pesanan.nomor_meja AS 'nomor_meja',
                        pesanan.nomor_lantai AS 'nomor_lantai',
                        pesanan.tgl_pesanan AS 'tanggal_pesanan',
                        pesanan.status AS 'status_pembayaran',
                        detail_pesanan.id_detail_pesanan AS 'id_detail_pesanan',
                        pesanan.id_pesanan AS 'id_pesanan',
                        menu.id_menu AS 'id_menu'
                    FROM detail_pesanan 
                        INNER JOIN menu  
                    ON detail_pesanan.menu_id = menu.id_menu 
                        INNER JOIN pesanan
                    ON detail_pesanan.pesanan_id = pesanan.id_pesanan
                        WHERE id_pesanan = @ID";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@ID", this.idPelanggan);

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

        private void detailMenu(string idMenu)
        {
            try
            {
                koneksi.openConnection();

                string query = @"SELECT * FROM menu
                        WHERE id_menu = @ID";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@ID", idMenu);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            this.price = dataTable.Rows[0]["harga"].ToString() ?? "0";
                            txtHarga.Text = this.price;
                        }
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

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.idMenu) || string.IsNullOrWhiteSpace(this.idPelanggan) ||
                string.IsNullOrWhiteSpace(this.totalOrder) || string.IsNullOrWhiteSpace(this.totalPrice) ||
                string.IsNullOrWhiteSpace(this.price))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();
                string query = @"UPDATE detail_pesanan SET menu_id = @IdMenu, harga = @Harga, jml_pesanan = @JmlPesanan, total_harga = @TotalHarga 
                        WHERE id_detail_pesanan = @IdDetailPesanan";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@IdPesanan", this.idPelanggan);
                    cmd.Parameters.AddWithValue("@IdMenu", this.idMenu);
                    cmd.Parameters.AddWithValue("@Harga", Convert.ToDecimal(this.price));
                    cmd.Parameters.AddWithValue("@JmlPesanan", Convert.ToInt32(this.totalOrder));
                    cmd.Parameters.AddWithValue("@TotalHarga", Convert.ToDecimal(this.totalPrice));
                    cmd.Parameters.AddWithValue("@IdDetailPesanan", Convert.ToDecimal(this.idDetailPesanan));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pesanan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataPesanan();
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui pesanan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal mengedit pesanan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if 
               (string.IsNullOrWhiteSpace(this.idMenu) 
               || string.IsNullOrWhiteSpace(this.idPelanggan) 
               || string.IsNullOrWhiteSpace(this.totalOrder) 
               || string.IsNullOrWhiteSpace(this.totalPrice) 
               || string.IsNullOrWhiteSpace(this.price)
            )
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();
                string query = @"INSERT INTO detail_pesanan (pesanan_id, menu_id, jml_pesanan, total_harga) 
                VALUES (@IdPesanan, @IdMenu, @JmlPesanan, @TotalHarga)";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@IdPesanan", string.IsNullOrEmpty(this.idPelanggan) ? DBNull.Value : this.idPelanggan);
                    cmd.Parameters.AddWithValue("@IdMenu", string.IsNullOrEmpty(this.idMenu) ? DBNull.Value : this.idMenu);
                    cmd.Parameters.AddWithValue("@JmlPesanan", string.IsNullOrEmpty(this.totalOrder) ? 0 : Convert.ToInt32(this.totalOrder));
                    cmd.Parameters.AddWithValue("@TotalHarga", string.IsNullOrEmpty(this.totalPrice) ? 0 : Convert.ToDecimal(this.totalPrice));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pesanan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataPesanan();
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan pesanan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal menambah pesanan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.idMenu) || string.IsNullOrWhiteSpace(this.idPelanggan))
            {
                MessageBox.Show("Pilih pesanan yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus pesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            try
            {
                koneksi.openConnection();
                string query = "DELETE FROM detail_pesanan WHERE id_detail_pesanan = @IdDetailPesanan";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@IdDetailPesanan", Convert.ToDecimal(this.idDetailPesanan));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pesanan berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataPesanan();
                        resetData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus pesanan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal menghapus pesanan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                this.price = row.Cells["harga"].Value?.ToString() ?? "0";
                this.idMenu = row.Cells["id_menu"].Value?.ToString() ?? "";
                this.idPelanggan = row.Cells["id_pesanan"].Value?.ToString() ?? "";
                this.totalOrder = row.Cells["jumlah"].Value?.ToString() ?? "0";
                this.totalPrice = row.Cells["total_harga"].Value?.ToString() ?? "0";
                this.idDetailPesanan = row.Cells["id_detail_pesanan"].Value?.ToString() ?? "";

                txtJumlahPesanan.Text = this.totalOrder;
                txtHarga.Text = this.price;
                txtTotalHarga.Text = this.totalPrice;

            }

        }

        private void calculateOrderPrice()
        {
            int harga = 0, jumlah = 0;

            int.TryParse(this.price, out harga);
            int.TryParse(this.totalOrder, out jumlah);

            this.totalPrice = (harga * jumlah).ToString();
            txtTotalHarga.Text = this.totalPrice;
        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idMenu = cmbMenu.SelectedValue?.ToString() ?? "";
            detailMenu(this.idMenu);
            calculateOrderPrice();
        }

        private void txtJumlahPesanan_TextChanged(object sender, EventArgs e)
        {
            this.totalOrder = txtJumlahPesanan.Text;
            calculateOrderPrice();
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            this.price = txtHarga.Text;
        }

        private void txtTotalHarga_TextChanged(object sender, EventArgs e)
        {
            this.totalPrice = txtTotalHarga.Text;
        }

        private void cmbPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idPelanggan = cmbPelanggan.SelectedValue?.ToString() ?? "";
            LoadDataPesanan();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.cmbPelanggan.SelectedIndex = -1;
            this.idPelanggan = "";
            resetData();
        }
    }
}
