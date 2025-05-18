using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace kasir
{
    internal class Koneksi
    {
        public SqlConnection getConn()
        {
            //App ini menggunakan Microsoft SQL Server sebagai database utama
            //Cek https://github.com/hafidzkhairul/AppKasir untuk penjelasan lebih lanjut
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data source=MYSTICT;initial catalog=DB_KASIR;integrated security=true";
            return Conn;
        }
    }
}
