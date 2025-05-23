﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kasir
{
    public partial class FormMasterKasir : Form
    {
        Koneksi konn = new Koneksi();
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private Button btnSearch;
        private SqlDataReader rd;

        void munculLevel()
        {
            comboBox1.Items.Add("ADMIN");
            comboBox1.Items.Add("KASIR");
        }

        void kondisiAwal()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            munculLevel();
            munculDataKasir();
        }

        public FormMasterKasir()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
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
            label1.Location = new Point(26, 38);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Kode Kasir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 67);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Kasir";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 96);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Password Kasir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 125);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Level Kasir";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 4;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(399, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(135, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(157, 23);
            textBox3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(135, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTutup);
            groupBox1.Controls.Add(btnHapus);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnInput);
            groupBox1.Location = new Point(26, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(508, 73);
            groupBox1.TabIndex = 8;
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
            dataGridView1.Location = new Point(26, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(508, 169);
            dataGridView1.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(298, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(83, 24);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Cari";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // FormMasterKasir
            // 
            ClientSize = new Size(591, 432);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterKasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Kasir";
            Load += FormMasterKasir_Load;
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Button btnTutup;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnInput;
        private DataGridView dataGridView1;
        private Label label4;


        void munculDataKasir()
        {
            //load data kasir
            SqlConnection conn = konn.getConn();
            conn.Open();
            cmd = new SqlCommand("select * from TBL_KASIR", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_KASIR");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TBL_KASIR";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();
        }

        private void FormMasterKasir_Load(object sender, EventArgs e)
        {
            kondisiAwal();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!!!");
            }
            else
            {
                SqlConnection conn = konn.getConn();
                cmd = new SqlCommand("insert into TBL_KASIR values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil di input");
                kondisiAwal();
            }
        }

        //press enter di textbox kode untuk search data
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SqlConnection conn = konn.getConn();
                cmd = new SqlCommand("select * from TBL_KASIR where KodeKasir= '" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    textBox1.Text = rd[0].ToString();
                    textBox2.Text = rd[1].ToString();
                    textBox3.Text = rd[2].ToString();
                    comboBox1.Text = rd[3].ToString();
                }
                else
                {
                    MessageBox.Show("Data Kasir Tidak Ada!!!");
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!!!");
            }
            else
            {
                SqlConnection conn = konn.getConn();
                cmd = new SqlCommand("update TBL_KASIR set NamaKasir='" + textBox2.Text + "', PasswordKasir='" + textBox3.Text + "',LevelKasir='" + comboBox1.Text + "' where KodeKasir='" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil di edit");
                kondisiAwal();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Pastikan Semua Form Terisi!!!");
            }
            else
            {
                SqlConnection conn = konn.getConn();
                cmd = new SqlCommand("delete TBL_KASIR where KodeKasir='" + textBox1.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("data berhasil di hapus");
                kondisiAwal();
            }
        }

        //search data kasir
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.getConn();
            cmd = new SqlCommand("select * from TBL_KASIR where KodeKasir= '" + textBox1.Text + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                textBox1.Text = rd[0].ToString();
                textBox2.Text = rd[1].ToString();
                textBox3.Text = rd[2].ToString();
                comboBox1.Text = rd[3].ToString();
            }
            else
            {
                MessageBox.Show("Data Kasir Tidak Ada!!!");
            }
        }
    }
}