using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace kasir
{
    public partial class FormTransJual : Form
    {
        FormLogin frmLogin = new FormLogin();
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        List<string> dataBarang = new List<string>();   //tampung data barang disini
        bool dataBarangAda = false;     //pengecekan untuk btn insert, memastikan barang yg di insert ada dalam dataBarang
        int jumlahItem = 0;
        int totalBelanja = 0;
        bool isNeedSaved = false;       //true jika ada data yg diinsert tapi belum disave di TBL_JUAL
        public FormTransJual()
        {
            InitializeComponent();
        }

        void kondisiAwal()
        {
            lblNamaBarang.Text = "";
            lblHarga.Text = "";
            lblKembali.Text = "";
            lblTotal.Text = "";
            lblItem.Text = "";
            lblStok.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            jumlahItem = 0;
            totalBelanja = 0;
            dataBarangAda = false;
            isNeedSaved = false;
            lblTanggal.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblJam.Text = DateTime.Now.ToString("HH:mm:ss");
            lblKasir.Text = FormLogin.NamaKasir;
            //get noJual
            SqlConnection conn = konn.getConn();
            cmd = new SqlCommand("select top 1 NoJual from TBL_JUAL order by TglJual DESC", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();
            string noJual = "";
            if (rd.Read())
            {
                noJual = rd[0].ToString();
                string no = noJual.Substring(2);
                int nomer = int.Parse(no) + 1;
                noJual = "NJ" + nomer.ToString();
            }
            else
            {
                noJual = "NJ1";
            }
            lblNoJual.Text = noJual;
            munculDetailJual();
        }

        void getDataBarang()
        {
            SqlConnection conn = konn.getConn();
            cmd = new SqlCommand("select KodeBarang+'-'+NamaBarang from TBL_BARANG", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string name = rd.GetString(0);
                dataBarang.Add(name);       //simpan kedalam list
                listBarang.Items.Add(name);
            }
        }

        void getDetailBarang()
        {
            SqlConnection conn = konn.getConn();
            cmd = new SqlCommand("select * from TBL_BARANG where KodeBarang='" + textBox1.Text + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                dataBarangAda = true;
                lblNamaBarang.Text = rd[1].ToString();
                lblHarga.Text = rd[2].ToString();
                lblStok.Text = rd[4].ToString();
            }
            else
            {
                dataBarangAda = false;
            }
        }

        void resetValueBarang()
        {
            textBox1.Text = "";
            lblNamaBarang.Text = "";
            lblHarga.Text = "";
            lblStok.Text = "";
            textBox2.Text = "";
        }

        void munculDetailJual()
        {
            SqlConnection conn = konn.getConn();
            conn.Open();
            cmd = new SqlCommand("select * from TBL_DETAILJUAL where Nojual='" + lblNoJual.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_DETAILJUAL");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TBL_DETAILJUAL";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }

        private void FormTransJual_Load(object sender, EventArgs e)
        {
            kondisiAwal();
            getDataBarang();
        }

        //show listbox berisi data barang ketika focus ada di textbox KODE
        private void textBox1_Enter(object sender, EventArgs e)
        {
            listBarang.Visible = true;
        }

        //hide listbox 
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!listBarang.Focus())
            {
                listBarang.Visible = false;
            }
        }

        //filter data barang by textbox KODE
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filter = textBox1.Text.ToLower();
            listBarang.Items.Clear();

            foreach (string item in dataBarang)
            {
                if (item.ToLower().Contains(filter))
                {
                    listBarang.Items.Add(item);
                }
            }
        }

        //autofill textbox KODE ketika memilih item di listBarang
        private void listBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBarang.SelectedItem == null)
            {

            }
            else
            {
                textBox1.Text = listBarang.SelectedItem.ToString().Split('-')[0];
                getDetailBarang();
            }
            listBarang.Visible = false;
        }

        //reset jika click listbox yg kosong
        private void listBarang_Click(object sender, EventArgs e)
        {
            if (listBarang.Items.Count == 0)
            {
                listBarang.Visible = false;
                resetValueBarang();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                getDetailBarang();
            }
        }

        //memastikan barang yg dibeli tidak melebihi stok
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int stok = lblStok.Text == "" ? 0 : int.Parse(lblStok.Text);
            int jumlah = textBox2.Text == "" ? 0 : int.Parse(textBox2.Text);
            if (jumlah > stok)
            {
                MessageBox.Show("Stok tidak mencukupi!");
                textBox2.Text = "";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the key
            }
        }

        //insert item ke TBL_DETAILJUAL
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (dataBarangAda && textBox2.Text != "")
            {
                int subtotal = int.Parse(textBox2.Text) * int.Parse(lblHarga.Text);
                SqlConnection conn = konn.getConn();
                cmd = new SqlCommand("insert into TBL_DETAILJUAL values('" + lblNoJual.Text + "','" + textBox1.Text + "','" + lblNamaBarang.Text + "','" + lblHarga.Text + "','" + textBox2.Text + "','" + subtotal.ToString() + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                jumlahItem++;
                totalBelanja += subtotal;
                lblItem.Text = jumlahItem.ToString();
                lblTotal.Text = totalBelanja.ToString();
                dataBarangAda = false;
                isNeedSaved = true;
                resetValueBarang();
                munculDetailJual();
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong!");
            }
        }

        //autofill label kembalian
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int bayar = textBox3.Text == "" ? 0 : int.Parse(textBox3.Text);
            int total = bayar - totalBelanja;
            lblKembali.Text = total.ToString();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the key
            }
        }

        //save data pembelian 
        private void button2_Click(object sender, EventArgs e)
        {
            int kembali = lblKembali.Text == "" ? -1 : int.Parse(lblKembali.Text);
            if (jumlahItem > 0 && kembali >= 0)
            {
                SqlConnection conn = konn.getConn();
                cmd = new SqlCommand("insert into TBL_JUAL values('" + lblNoJual.Text + "','" + DateTime.Now + "','" + jumlahItem.ToString() + "','" + totalBelanja.ToString() + "','" + textBox3.Text + "','" + lblKembali.Text + "','" + FormLogin.KodeKasir + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                //kurangi stok barang
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow) // avoid the empty new row at the bottom
                    {
                        string kode = row.Cells[2].Value?.ToString();
                        int stokDibeli = int.Parse(row.Cells[5].Value?.ToString());
                        int stok = 0;
                        cmd = new SqlCommand("select JumlahBarang from TBL_BARANG where KodeBarang='" + kode + "'", conn);
                        //conn.Open();
                        cmd.ExecuteNonQuery();
                        rd = cmd.ExecuteReader();
                        if (rd.Read())
                        {
                            stok = int.Parse(rd[0].ToString());
                        }
                        rd.Close();
                        int readyStok = stok - stokDibeli;

                        cmd = new SqlCommand("update TBL_BARANG set JumlahBarang=" + readyStok.ToString() + " where KodeBarang='"+kode+"'", conn);
                        //conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil disimpan!");
                kondisiAwal();
                lblKembali.Text = "";
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong!");
            }
        }

        //warning ketika close menu tapi belum save data pembelian
        private void FormTransJual_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isNeedSaved)
            {
                DialogResult result = MessageBox.Show(
                "Data belum disimpan! Anda yakin ingin keluar?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the close
                }
                else{
                    //hapus item yg sudah di insert
                    SqlConnection conn = konn.getConn();
                    cmd = new SqlCommand("delete TBL_DETAILJUAL where NoJual='" + lblNoJual.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        void generateStrukPembelian()
        {

        }

    }
}
