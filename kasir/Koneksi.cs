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
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=appkasir";
            return Conn;
        }
    }
}
