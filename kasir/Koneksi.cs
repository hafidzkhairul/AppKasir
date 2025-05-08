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
            //
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data source=MYSTICT;initial catalog=DB_KASIR;integrated security=true";
            return Conn;
        }
    }
}
