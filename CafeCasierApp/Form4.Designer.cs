namespace CafeCasierApp
{
    partial class PenggunaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenggunaForm));
            panel2 = new Panel();
            btnExit = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            tableData = new DataGridView();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            btnTambah = new Button();
            btnRefresh = new Button();
            btnHapus = new Button();
            btnEdit = new Button();
            btnBack = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableData).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 34);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(250, 50);
            label1.TabIndex = 1;
            label1.Text = "Kelola Data Pengguna";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnHapus);
            panel3.Controls.Add(btnRefresh);
            panel3.Controls.Add(btnTambah);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(tableData);
            panel3.Location = new Point(31, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(727, 390);
            panel3.TabIndex = 1;
            // 
            // tableData
            // 
            tableData.BackgroundColor = Color.FromArgb(72, 23, 0);
            tableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableData.GridColor = SystemColors.InactiveCaption;
            tableData.Location = new Point(335, 88);
            tableData.Name = "tableData";
            tableData.Size = new Size(354, 244);
            tableData.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 39);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ScrollBar;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(33, 64);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 36);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 113);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(78, 20);
            label3.TabIndex = 6;
            label3.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(33, 138);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 36);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 189);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(73, 20);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9F);
            textBox2.Location = new Point(33, 214);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 36);
            textBox2.TabIndex = 7;
            // 
            // btnTambah
            // 
            btnTambah.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.Location = new Point(33, 278);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(83, 44);
            btnTambah.TabIndex = 9;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
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
            // 
            // btnHapus
            // 
            btnHapus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.Location = new Point(122, 278);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(83, 44);
            btnHapus.TabIndex = 11;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(211, 278);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(83, 44);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
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
            // PenggunaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PenggunaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Data Pengguna";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnExit;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private DataGridView tableData;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtEmail;
        private Button btnEdit;
        private Button btnHapus;
        private Button btnRefresh;
        private Button btnTambah;
        private Button btnBack;
    }
}