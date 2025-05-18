using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir
{
    public partial class FormMenuUtama : Form
    {
        public static FormMenuUtama menu;
        FormLogin frmLogin;
        void frmLogin_Closed(object sender, FormClosedEventArgs e)
        {
            frmLogin = null;
        }
        FormMasterKasir frmKasir;
        void frmKasir_Closed(object sender, FormClosedEventArgs e)
        {
            frmKasir = null;
        }
        FormMasterBarang frmBarang;
        void frmBarang_Closed(object sender, FormClosedEventArgs e)
        {
            frmBarang = null;
        }

        FormTransJual frmTransJual;
        void frmTransJual_Closed(object sender, FormClosedEventArgs e)
        {
            frmTransJual = null;
        }

        void menuTerkunci()
        {
            menuLogin.Enabled = true;
            menuLogout.Enabled = false;
            menuMaster.Enabled = false;
            menuTransaksi.Enabled = false;
            menuUtility.Enabled = false;
            menuLaporan.Enabled = false;
            menu = this;
        }

        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            menuTerkunci();
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            //mencegah duplikasi form yg masih dibuka
            if (frmLogin == null)
            {
                frmLogin = new FormLogin();
                frmLogin.FormClosed += new FormClosedEventHandler(frmLogin_Closed);
                frmLogin.ShowDialog();
            }
            else
            {
                frmLogin.Activate();
            }
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            menuTerkunci();
        }

        private void menuKasir_Click(object sender, EventArgs e)
        {

            if (frmKasir == null)
            {
                frmKasir = new FormMasterKasir();
                frmKasir.FormClosed += new FormClosedEventHandler(frmKasir_Closed);
                frmKasir.ShowDialog();
            }
            else
            {
                frmKasir.Activate();
            }
        }

        private void menuBarang_Click(object sender, EventArgs e)
        {
            if (frmBarang == null)
            {
                frmBarang = new FormMasterBarang();
                frmBarang.FormClosed += new FormClosedEventHandler(frmBarang_Closed);
                frmBarang.ShowDialog();
            }
            else
            {
                frmBarang.Activate();
            }
        }

        private void menuPenjualan_Click(object sender, EventArgs e)
        {
            if (frmTransJual == null)
            {
                frmTransJual = new FormTransJual();
                frmTransJual.FormClosed += new FormClosedEventHandler(frmTransJual_Closed);
                frmTransJual.ShowDialog();
            }
            else
            {
                frmTransJual.Activate();
            }
        }
    }
}
