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
        private string idMenu, idPelanggan, totalOrder, totalPrice, price;
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
            this.idPelanggan = "";
            this.totalOrder = "";
            this.totalPrice = "";
            this.price = "";

            txtHarga.Text = "";
            txtJumlahPesanan.Text = "";
            txtTotalHarga.Text = "";

            cmbPelanggan.SelectedIndex = -1;
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
                        pesanan.jml_pesanan AS 'jumlah',
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

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

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
                txtJumlahPesanan.Text = this.totalOrder;
                txtHarga.Text = this.price;
                calculateOrderPrice();
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
            resetData();
        }
    }
}
