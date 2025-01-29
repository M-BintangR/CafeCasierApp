namespace CafeCasierApp
{
    partial class PembayaranForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PembayaranForm));
            label1 = new Label();
            panel2 = new Panel();
            btnBack = new Button();
            btnExit = new Button();
            label5 = new Label();
            cmbPelanggan = new ComboBox();
            panel3 = new Panel();
            label6 = new Label();
            label3 = new Label();
            btnRefresh = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            txtNomorLantai = new TextBox();
            tableData = new DataGridView();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(220, 50);
            label1.TabIndex = 1;
            label1.Text = "Kelola Pembayaran";
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
            panel2.Size = new Size(648, 112);
            panel2.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(72, 23, 0);
            btnBack.Location = new Point(484, 43);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(131, 41);
            btnBack.TabIndex = 2;
            btnBack.Text = "Kembali";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(72, 23, 0);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(337, 43);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 41);
            btnExit.TabIndex = 0;
            btnExit.Text = "Keluar";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 52);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(112, 20);
            label5.TabIndex = 19;
            label5.Text = "Cari Pelanggan";
            // 
            // cmbPelanggan
            // 
            cmbPelanggan.FormattingEnabled = true;
            cmbPelanggan.Location = new Point(31, 78);
            cmbPelanggan.Name = "cmbPelanggan";
            cmbPelanggan.Size = new Size(354, 23);
            cmbPelanggan.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtNomorLantai);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cmbPelanggan);
            panel3.Controls.Add(tableData);
            panel3.Location = new Point(31, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 451);
            panel3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(410, 22);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(162, 20);
            label6.TabIndex = 25;
            label6.Text = "STATUS PEMBAYARAN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(420, 54);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 5, 10, 5);
            label3.Size = new Size(141, 47);
            label3.TabIndex = 24;
            label3.Text = "UNPAID";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Lime;
            btnRefresh.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(410, 359);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(151, 61);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "BAYAR";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(148, 359);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(88, 20);
            label2.TabIndex = 23;
            label2.Text = "Total Harga";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(148, 384);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 36);
            textBox1.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 359);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(76, 20);
            label4.TabIndex = 21;
            label4.Text = "Total Item";
            // 
            // txtNomorLantai
            // 
            txtNomorLantai.BackColor = SystemColors.ScrollBar;
            txtNomorLantai.BorderStyle = BorderStyle.None;
            txtNomorLantai.Font = new Font("Segoe UI", 9F);
            txtNomorLantai.Location = new Point(34, 384);
            txtNomorLantai.Multiline = true;
            txtNomorLantai.Name = "txtNomorLantai";
            txtNomorLantai.Size = new Size(95, 36);
            txtNomorLantai.TabIndex = 20;
            // 
            // tableData
            // 
            tableData.BackgroundColor = Color.FromArgb(72, 23, 0);
            tableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableData.GridColor = SystemColors.InactiveCaption;
            tableData.Location = new Point(31, 126);
            tableData.Name = "tableData";
            tableData.Size = new Size(530, 218);
            tableData.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Premium_Vector___Coffee_Beans_seamless_Pattern_Cute_vector_background;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 618);
            panel1.TabIndex = 6;
            // 
            // PembayaranForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 618);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PembayaranForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableData).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Button btnBack;
        private Button btnExit;
        private Label label5;
        private ComboBox cmbPelanggan;
        private Panel panel3;
        private Button btnRefresh;
        private DataGridView tableData;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private TextBox txtNomorLantai;
        private Label label6;
    }
}