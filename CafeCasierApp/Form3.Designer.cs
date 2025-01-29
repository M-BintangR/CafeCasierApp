namespace CafeCasierApp
{
    partial class KasirPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasirPanelForm));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            panel1 = new Panel();
            btnPembayaran = new Button();
            btnPesanan = new Button();
            btnPelanggan = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 112);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 77);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(72, 23, 0);
            btnExit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(662, 34);
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
            panel1.Controls.Add(btnPembayaran);
            panel1.Controls.Add(btnPesanan);
            panel1.Controls.Add(btnPelanggan);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 453);
            panel1.TabIndex = 1;
            // 
            // btnPembayaran
            // 
            btnPembayaran.BackgroundImage = (Image)resources.GetObject("btnPembayaran.BackgroundImage");
            btnPembayaran.Location = new Point(490, 219);
            btnPembayaran.Name = "btnPembayaran";
            btnPembayaran.Size = new Size(110, 110);
            btnPembayaran.TabIndex = 5;
            btnPembayaran.UseVisualStyleBackColor = true;
            btnPembayaran.Click += btnPembayaran_Click;
            // 
            // btnPesanan
            // 
            btnPesanan.BackgroundImage = (Image)resources.GetObject("btnPesanan.BackgroundImage");
            btnPesanan.Location = new Point(360, 219);
            btnPesanan.Name = "btnPesanan";
            btnPesanan.Size = new Size(110, 110);
            btnPesanan.TabIndex = 4;
            btnPesanan.UseVisualStyleBackColor = true;
            btnPesanan.Click += btnPesanan_Click;
            // 
            // btnPelanggan
            // 
            btnPelanggan.BackgroundImage = (Image)resources.GetObject("btnPelanggan.BackgroundImage");
            btnPelanggan.Location = new Point(226, 219);
            btnPelanggan.Name = "btnPelanggan";
            btnPelanggan.Size = new Size(110, 110);
            btnPelanggan.TabIndex = 3;
            btnPelanggan.UseVisualStyleBackColor = true;
            btnPelanggan.Click += btnPelanggan_Click;
            // 
            // KasirPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 453);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KasirPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kasir Panel";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Panel panel1;
        private Button btnPelanggan;
        private Button btnPembayaran;
        private Button btnPesanan;
    }
}