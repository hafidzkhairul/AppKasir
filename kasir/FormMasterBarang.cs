using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir
{
    public partial class FormMasterBarang : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private Button btnSearch;
        private SqlDataReader rd;

        void munculSatuan()
        {
            comboBox1.Items.Add("PCS");
            comboBox1.Items.Add("BOX");
            comboBox1.Items.Add("BOTOL");
            comboBox1.Items.Add("PAX");
            comboBox1.Items.Add("KILO");
            comboBox1.Items.Add("KARUNG");
        }

        void kondisiAwal()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            munculSatuan();
            munculDataBarang();
        }

        void munculDataBarang()
        {
            SqlConnection conn = konn.getConn();
            conn.Open();
            cmd = new SqlCommand("select * from TBL_BARANG", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_BARANG");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TBL_BARANG";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
        }
        public FormMasterBarang()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            btnTutup = new Button();
            btnHapus = new Button();
            btnEdit = new Button();
            btnInput = new Button();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Kode Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 57);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 91);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "Harga Beli";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 125);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Harga Jual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 160);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "Jumlah Barang";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 194);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 5;
            label6.Text = "Satuan Barang";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 6;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(416, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(134, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(134, 122);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(166, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(134, 157);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(166, 23);
            textBox5.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(134, 191);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTutup);
            groupBox1.Controls.Add(btnHapus);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnInput);
            groupBox1.Location = new Point(32, 230);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(588, 73);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Proses";
            // 
            // btnTutup
            // 
            btnTutup.Location = new Point(331, 22);
            btnTutup.Name = "btnTutup";
            btnTutup.Size = new Size(99, 45);
            btnTutup.TabIndex = 3;
            btnTutup.Text = "TUTUP";
            btnTutup.UseVisualStyleBackColor = true;
            btnTutup.Click += btnTutup_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(229, 22);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(96, 45);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "HAPUS";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(124, 22);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(99, 45);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnInput
            // 
            btnInput.Location = new Point(10, 22);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(106, 45);
            btnInput.TabIndex = 0;
            btnInput.Text = "INPUT";
            btnInput.UseVisualStyleBackColor = true;
            btnInput.Click += btnInput_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(589, 209);
            dataGridView1.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(306, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(87, 26);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Cari";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // FormMasterBarang
            // 
            ClientSize = new Size(654, 541);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterBarang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Master Barang";
            Load += FormMasterBarang_Load;
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Button btnTutup;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnInput;
        private DataGridView dataGridView1;
        private Label label5;

        private void FormMasterBarang_Load(object sender, EventArgs e)
        {
            kondisiAwal();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!!!");
            }
            else
            {
                SqlConnection conn = konn.getConn();
                cmd = new SqlCommand("insert into TBL_BARANG values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil di input");
                kondisiAwal();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!!!");
            }
            else
            {
                SqlConnection conn = konn.getConn();
                cmd = new SqlCommand("update TBL_BARANG set NamaBarang='" + textBox2.Text + "', HargaJual='" + textBox4.Text + "',HargaBeli='" + textBox3.Text + "',JumlahBarang='" + textBox5.Text + "',SatuanBarang='" + comboBox1.Text + "' where KodeBarang='" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil di edit");
                kondisiAwal();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!!!");
            }
            else
            {
                SqlConnection conn = konn.getConn();
                cmd = new SqlCommand("delete TBL_BARANG where KodeBarang='" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil di hapus");
                kondisiAwal();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection conn = konn.getConn();
                cmd = new SqlCommand("select * from TBL_BARANG where KodeBarang= '" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    textBox1.Text = rd[0].ToString();
                    textBox2.Text = rd[1].ToString();
                    textBox4.Text = rd[2].ToString();
                    textBox3.Text = rd[3].ToString();
                    textBox5.Text = rd[4].ToString();
                    comboBox1.Text = rd[5].ToString();
                }
                else
                {
                    MessageBox.Show("Data Barang Tidak Ada!!!");
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.getConn();
            cmd = new SqlCommand("select * from TBL_BARANG where KodeBarang= '" + textBox1.Text + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                textBox1.Text = rd[0].ToString();
                textBox2.Text = rd[1].ToString();
                textBox4.Text = rd[2].ToString();
                textBox3.Text = rd[3].ToString();
                textBox5.Text = rd[4].ToString();
                comboBox1.Text = rd[5].ToString();
            }
            else
            {
                MessageBox.Show("Data Barang Tidak Ada!!!");
            }
        }
    }
}
