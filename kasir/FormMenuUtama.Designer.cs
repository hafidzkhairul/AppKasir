namespace kasir
{
    partial class FormMenuUtama
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
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuLogin = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuMaster = new ToolStripMenuItem();
            menuKasir = new ToolStripMenuItem();
            menuBarang = new ToolStripMenuItem();
            menuTransaksi = new ToolStripMenuItem();
            menuPenjualan = new ToolStripMenuItem();
            menuLaporan = new ToolStripMenuItem();
            menuLapDataMaster = new ToolStripMenuItem();
            menuLapPenjualan = new ToolStripMenuItem();
            menuUtility = new ToolStripMenuItem();
            menuGantiPassword = new ToolStripMenuItem();
            menuAbout = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuMaster, menuTransaksi, menuLaporan, menuUtility });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(841, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuLogin, menuLogout, toolStripMenuItem1, exitToolStripMenuItem });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(37, 20);
            menuFile.Text = "File";
            // 
            // menuLogin
            // 
            menuLogin.Name = "menuLogin";
            menuLogin.Size = new Size(180, 22);
            menuLogin.Text = "Login";
            menuLogin.Click += menuLogin_Click;
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(180, 22);
            menuLogout.Text = "Logout";
            menuLogout.Click += menuLogout_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // menuMaster
            // 
            menuMaster.DropDownItems.AddRange(new ToolStripItem[] { menuKasir, menuBarang });
            menuMaster.Name = "menuMaster";
            menuMaster.Size = new Size(55, 20);
            menuMaster.Text = "Master";
            // 
            // menuKasir
            // 
            menuKasir.Name = "menuKasir";
            menuKasir.Size = new Size(180, 22);
            menuKasir.Text = "Kasir";
            menuKasir.Click += menuKasir_Click;
            // 
            // menuBarang
            // 
            menuBarang.Name = "menuBarang";
            menuBarang.Size = new Size(180, 22);
            menuBarang.Text = "Barang";
            // 
            // menuTransaksi
            // 
            menuTransaksi.DropDownItems.AddRange(new ToolStripItem[] { menuPenjualan });
            menuTransaksi.Name = "menuTransaksi";
            menuTransaksi.Size = new Size(67, 20);
            menuTransaksi.Text = "Transaksi";
            // 
            // menuPenjualan
            // 
            menuPenjualan.Name = "menuPenjualan";
            menuPenjualan.Size = new Size(126, 22);
            menuPenjualan.Text = "Penjualan";
            // 
            // menuLaporan
            // 
            menuLaporan.DropDownItems.AddRange(new ToolStripItem[] { menuLapDataMaster, menuLapPenjualan });
            menuLaporan.Name = "menuLaporan";
            menuLaporan.Size = new Size(62, 20);
            menuLaporan.Text = "Laporan";
            // 
            // menuLapDataMaster
            // 
            menuLapDataMaster.Name = "menuLapDataMaster";
            menuLapDataMaster.Size = new Size(137, 22);
            menuLapDataMaster.Text = "Data Master";
            // 
            // menuLapPenjualan
            // 
            menuLapPenjualan.Name = "menuLapPenjualan";
            menuLapPenjualan.Size = new Size(137, 22);
            menuLapPenjualan.Text = "Penjualan";
            // 
            // menuUtility
            // 
            menuUtility.DropDownItems.AddRange(new ToolStripItem[] { menuGantiPassword, menuAbout });
            menuUtility.Name = "menuUtility";
            menuUtility.Size = new Size(50, 20);
            menuUtility.Text = "Utility";
            // 
            // menuGantiPassword
            // 
            menuGantiPassword.Name = "menuGantiPassword";
            menuGantiPassword.Size = new Size(155, 22);
            menuGantiPassword.Text = "Ganti Password";
            // 
            // menuAbout
            // 
            menuAbout.Name = "menuAbout";
            menuAbout.Size = new Size(155, 22);
            menuAbout.Text = "About";
            // 
            // FormMenuUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 485);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenuUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuUtama";
            WindowState = FormWindowState.Maximized;
            Load += FormMenuUtama_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem menuFile;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem menuKasir;
        private ToolStripMenuItem menuBarang;
        private ToolStripMenuItem menuPenjualan;
        private ToolStripMenuItem menuLapDataMaster;
        private ToolStripMenuItem menuLapPenjualan;
        private ToolStripMenuItem menuGantiPassword;
        private ToolStripMenuItem menuAbout;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem menuLogin;
        public ToolStripMenuItem menuLogout;
        public ToolStripMenuItem menuMaster;
        public ToolStripMenuItem menuTransaksi;
        public ToolStripMenuItem menuLaporan;
        public ToolStripMenuItem menuUtility;
    }
}