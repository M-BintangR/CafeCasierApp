namespace CafeCasierApp
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            btnEdit = new Button();
            btnHapus = new Button();
            btnRefresh = new Button();
            btnTambah = new Button();
            label2 = new Label();
            txtNamaMenu = new TextBox();
            tableData = new DataGridView();
            btnBack = new Button();
            label1 = new Label();
            btnExit = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            txtKeterangan = new TextBox();
            label3 = new Label();
            txtHarga = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tableData).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(214, 308);
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
            btnHapus.Location = new Point(125, 308);
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
            btnTambah.Location = new Point(36, 308);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(83, 44);
            btnTambah.TabIndex = 9;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 39);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(94, 20);
            label2.TabIndex = 4;
            label2.Text = "Nama Menu";
            // 
            // txtNamaMenu
            // 
            txtNamaMenu.BackColor = SystemColors.ScrollBar;
            txtNamaMenu.BorderStyle = BorderStyle.None;
            txtNamaMenu.Font = new Font("Segoe UI", 9F);
            txtNamaMenu.Location = new Point(33, 64);
            txtNamaMenu.Multiline = true;
            txtNamaMenu.Name = "txtNamaMenu";
            txtNamaMenu.Size = new Size(261, 36);
            txtNamaMenu.TabIndex = 3;
            txtNamaMenu.TextChanged += txtNamaMenu_TextChanged;
            // 
            // tableData
            // 
            tableData.BackgroundColor = Color.FromArgb(72, 23, 0);
            tableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableData.GridColor = SystemColors.InactiveCaption;
            tableData.Location = new Point(335, 88);
            tableData.Name = "tableData";
            tableData.Size = new Size(354, 264);
            tableData.TabIndex = 2;
            tableData.CellContentClick += tableData_CellContentClick;
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
            label1.Size = new Size(208, 50);
            label1.TabIndex = 1;
            label1.Text = "Kelola Data Menu";
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
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Premium_Vector___Coffee_Beans_seamless_Pattern_Cute_vector_background;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 565);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtKeterangan);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtHarga);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnHapus);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnTambah);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtNamaMenu);
            panel3.Controls.Add(tableData);
            panel3.Location = new Point(31, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(727, 390);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 194);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(88, 20);
            label4.TabIndex = 16;
            label4.Text = "Keterangan";
            // 
            // txtKeterangan
            // 
            txtKeterangan.BackColor = SystemColors.ScrollBar;
            txtKeterangan.BorderStyle = BorderStyle.None;
            txtKeterangan.Font = new Font("Segoe UI", 9F);
            txtKeterangan.Location = new Point(33, 219);
            txtKeterangan.Multiline = true;
            txtKeterangan.Name = "txtKeterangan";
            txtKeterangan.Size = new Size(261, 68);
            txtKeterangan.TabIndex = 15;
            txtKeterangan.TextChanged += txtKeterangan_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 117);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(51, 20);
            label3.TabIndex = 14;
            label3.Text = "Harga";
            // 
            // txtHarga
            // 
            txtHarga.BackColor = SystemColors.ScrollBar;
            txtHarga.BorderStyle = BorderStyle.None;
            txtHarga.Font = new Font("Segoe UI", 9F);
            txtHarga.Location = new Point(33, 142);
            txtHarga.Multiline = true;
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(261, 36);
            txtHarga.TabIndex = 13;
            txtHarga.TextChanged += txtHarga_TextChanged;
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
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)tableData).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEdit;
        private Button btnHapus;
        private Button btnRefresh;
        private Button btnTambah;
        private Label label2;
        private TextBox txtNamaMenu;
        private DataGridView tableData;
        private Button btnBack;
        private Label label1;
        private Button btnExit;
        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private TextBox txtHarga;
        private Panel panel2;
        private Label label4;
        private TextBox txtKeterangan;
    }
}