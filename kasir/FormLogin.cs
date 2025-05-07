using System.Data;
using System.Data.SqlClient;

namespace kasir
{
    public partial class FormLogin : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        Koneksi Konn = new Koneksi();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = Konn.getConn();
            {
                conn.Open();
                cmd = new SqlCommand("select * from tbl_kasir where KodeKasir='"+textBox1.Text+"' and PasswordKasir ='"+textBox2.Text+"'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FormMenuUtama frmUtama = new FormMenuUtama();
                    frmUtama.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password Salah");
                }
            }


            //if (textBox1.Text == "KSR001" && textBox2.Text == "admin" )
            //{
            //    FormMenuUtama frmUtama = new FormMenuUtama();
            //    frmUtama.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Password Salah");
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
