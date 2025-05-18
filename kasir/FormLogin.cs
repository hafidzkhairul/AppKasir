using System.Data;
using System.Data.SqlClient;

namespace kasir
{
    public partial class FormLogin : Form
    {
        public static string KodeKasir = "";
        public static string NamaKasir = "";
        public static string PasswordKasir = "";
        public static string LevelKasir = "";
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
                cmd = new SqlCommand("select * from TBL_KASIR where KodeKasir='" + textBox1.Text + "' and PasswordKasir ='" + textBox2.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    KodeKasir = reader[0].ToString();
                    NamaKasir = reader[1].ToString();
                    PasswordKasir = reader[2].ToString();
                    LevelKasir = reader[3].ToString();
                    FormMenuUtama.menu.menuLogin.Enabled = false;
                    FormMenuUtama.menu.menuLogout.Enabled = true;
                    //Menu master hanya bisa dibuka oleh admin 
                    if(LevelKasir.Trim() == "ADMIN")
                    {
                        FormMenuUtama.menu.menuMaster.Enabled = true;
                    }
                    else
                    {
                        FormMenuUtama.menu.menuMaster.Enabled = false;
                    }
                    FormMenuUtama.menu.menuTransaksi.Enabled = true;
                    FormMenuUtama.menu.menuLaporan.Enabled = true;
                    FormMenuUtama.menu.menuUtility.Enabled = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password Salah");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            //textBox1.Text = "ADM001";
            //textBox2.Text = "ADMIN";
        }
    }
}
