using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeCasierApp
{
    public partial class PembayaranForm : Form
    {
        private readonly Koneksi koneksi;
        private DataTable dataTable;
        private string idPelanggan, totalItem, totalBayar;
        public PembayaranForm()
        {
            InitializeComponent();
            koneksi = new Koneksi();
            LoadDataPelanggan();

            this.statusPayment.Visible = false;
            this.lblStatusPayment.Visible = false;
            this.btnPayment.Enabled = true;
        }

        public void resetData()
        {
            this.idPelanggan = "";
            this.totalItem = "";
            this.totalBayar = "";
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
                MessageBox.Show($"Gagal load data pelanggan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        private void LoadDetailPesanan(string idPesanan)
        {
            try
            {
                koneksi.openConnection();

                string query = @"SELECT * FROM pesanan
                        WHERE id_pesanan = @IdPesanan";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        cmd.Parameters.AddWithValue("@IdPesanan", this.idPelanggan);

                        dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            string status = dataTable.Rows[0]["status"].ToString() ?? "";
                            statusPayment.Visible = true;
                            lblStatusPayment.Visible = true;
                            statusPayment.Text = status;

                            if (status == "PAID")
                            {
                                statusPayment.BackColor = Color.LimeGreen;
                                btnPayment.Visible = false;
                            }
                            else
                            {
                                statusPayment.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal load data pesanan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        this.totalItem = dataTable.Compute("SUM(jumlah)", "").ToString() ?? "0";
                        this.totalBayar = dataTable.Compute("SUM(total_harga)", "").ToString() ?? "0";
                    }
                }

                txtTotalHarga.Text = "Rp. " + this.totalBayar;
                txtTotalItem.Text = this.totalItem;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal load data pengguna: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {err.Message}");
            }
            finally
            {
                koneksi.CloseConnection();
            }
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

        private void cmbPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idPelanggan = cmbPelanggan.SelectedValue?.ToString() ?? "";

            if (!string.IsNullOrWhiteSpace(this.idPelanggan) && !string.IsNullOrEmpty(this.idPelanggan))
            {
                LoadDataPesanan();
                LoadDetailPesanan(this.idPelanggan);
            }
           
        }

        private void tableData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idPelanggan))
            {
                MessageBox.Show("Pilih pelanggan yang akan di bayar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                koneksi.openConnection();
                string query = "UPDATE pesanan SET status = @Status WHERE id_pesanan = @ID";

                using (MySqlCommand cmd = new MySqlCommand(query, koneksi.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Status", "PAID");
                    cmd.Parameters.AddWithValue("@ID", this.idPelanggan);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data pelanggan berhasil di bayarkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDetailPesanan(this.idPelanggan);
                    }
                    else
                    {
                        MessageBox.Show("Gagal membayar data pelanggan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Gagal membayar pelanggan: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }
    }
}
