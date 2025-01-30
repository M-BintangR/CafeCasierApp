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

        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idMenu = cmbMenu.SelectedValue?.ToString() ?? "";
        }

        private void txtJumlahPesanan_TextChanged(object sender, EventArgs e)
        {
            this.totalOrder = txtJumlahPesanan.Text;
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
