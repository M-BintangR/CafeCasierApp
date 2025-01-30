namespace CafeCasierApp
{
    partial class PesananForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesananForm));
            txtJumlahPesanan = new TextBox();
            label4 = new Label();
            txtHarga = new TextBox();
            label3 = new Label();
            btnEdit = new Button();
            btnHapus = new Button();
            btnRefresh = new Button();
            btnTambah = new Button();
            tableData = new DataGridView();
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            txtTotalHarga = new TextBox();
            label7 = new Label();
            cmbMenu = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            cmbPelanggan = new ComboBox();
            panel2 = new Panel();
            btnBack = new Button();
            label1 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)tableData).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtJumlahPesanan
            // 
            txtJumlahPesanan.BackColor = SystemColors.ScrollBar;
            txtJumlahPesanan.BorderStyle = BorderStyle.None;
            txtJumlahPesanan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtJumlahPesanan.Location = new Point(33, 140);
            txtJumlahPesanan.Multiline = true;
            txtJumlahPesanan.Name = "txtJumlahPesanan";
            txtJumlahPesanan.Size = new Size(261, 36);
            txtJumlahPesanan.TabIndex = 17;
            txtJumlahPesanan.TextChanged += txtJumlahPesanan_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 189);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(51, 20);
            label4.TabIndex = 16;
            label4.Text = "Harga";
            // 
            // txtHarga
            // 
            txtHarga.BackColor = SystemColors.ScrollBar;
            txtHarga.BorderStyle = BorderStyle.None;
            txtHarga.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtHarga.Location = new Point(33, 214);
            txtHarga.Multiline = true;
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(261, 36);
            txtHarga.TabIndex = 15;
            txtHarga.TextChanged += txtHarga_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 117);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(118, 20);
            label3.TabIndex = 14;
            label3.Text = "Jumlah Pesanan";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(123, 357);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(83, 44);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.Location = new Point(211, 357);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(83, 44);
            btnHapus.TabIndex = 11;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(72, 23, 0);
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(600, 28);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(89, 44);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnTambah
            // 
            btnTambah.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.Location = new Point(33, 357);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(83, 44);
            btnTambah.TabIndex = 9;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // tableData
            // 
            tableData.BackgroundColor = Color.FromArgb(72, 23, 0);
            tableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableData.GridColor = SystemColors.InactiveCaption;
            tableData.Location = new Point(335, 154);
            tableData.Name = "tableData";
            tableData.Size = new Size(354, 247);
            tableData.TabIndex = 2;
            tableData.CellContentClick += tableData_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Premium_Vector___Coffee_Beans_seamless_Pattern_Cute_vector_background;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 648);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtTotalHarga);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(cmbMenu);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cmbPelanggan);
            panel3.Controls.Add(txtJumlahPesanan);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtHarga);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnHapus);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnTambah);
            panel3.Controls.Add(tableData);
            panel3.Location = new Point(31, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(727, 451);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 266);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(88, 20);
            label2.TabIndex = 24;
            label2.Text = "Total Harga";
            // 
            // txtTotalHarga
            // 
            txtTotalHarga.BackColor = SystemColors.ScrollBar;
            txtTotalHarga.BorderStyle = BorderStyle.None;
            txtTotalHarga.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtTotalHarga.Location = new Point(33, 291);
            txtTotalHarga.Multiline = true;
            txtTotalHarga.Name = "txtTotalHarga";
            txtTotalHarga.Size = new Size(261, 36);
            txtTotalHarga.TabIndex = 23;
            txtTotalHarga.TextChanged += txtTotalHarga_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 46);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(83, 20);
            label7.TabIndex = 22;
            label7.Text = "Pilih Menu";
            // 
            // cmbMenu
            // 
            cmbMenu.FormattingEnabled = true;
            cmbMenu.Location = new Point(33, 72);
            cmbMenu.Name = "cmbMenu";
            cmbMenu.Size = new Size(261, 23);
            cmbMenu.TabIndex = 21;
            cmbMenu.SelectedIndexChanged += cmbMenu_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(338, 124);
            label6.Name = "label6";
            label6.Size = new Size(178, 15);
            label6.TabIndex = 20;
            label6.Text = "Cari pelanggan terlebih dahulu *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(335, 71);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(112, 20);
            label5.TabIndex = 19;
            label5.Text = "Cari Pelanggan";
            // 
            // cmbPelanggan
            // 
            cmbPelanggan.FormattingEnabled = true;
            cmbPelanggan.Location = new Point(335, 97);
            cmbPelanggan.Name = "cmbPelanggan";
            cmbPelanggan.Size = new Size(354, 23);
            cmbPelanggan.TabIndex = 18;
            cmbPelanggan.SelectedIndexChanged += cmbPelanggan_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 112);
            panel2.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(72, 23, 0);
            btnBack.Location = new Point(644, 32);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(131, 41);
            btnBack.TabIndex = 2;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(180, 50);
            label1.TabIndex = 1;
            label1.Text = "Kelola Pesanan";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(72, 23, 0);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(497, 32);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 41);
            btnExit.TabIndex = 0;
            btnExit.Text = "Keluar";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // PesananForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 648);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PesananForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Pesanan";
            ((System.ComponentModel.ISupportInitialize)tableData).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtJumlahPesanan;
        private Label label4;
        private TextBox txtHarga;
        private Label label3;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnRefresh;
        private Button btnTambah;
        private DataGridView tableData;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button btnBack;
        private Label label1;
        private Button btnExit;
        private Label label7;
        private ComboBox cmbMenu;
        private Label label6;
        private Label label5;
        private ComboBox cmbPelanggan;
        private Label label2;
        private TextBox txtTotalHarga;
    }
}