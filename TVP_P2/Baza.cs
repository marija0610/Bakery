using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_P2
{
    class Baza
    {
        OleDbConnection conn;

        public Baza()
        {
            this.conn = new OleDbConnection();
            //conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Nikolici\Desktop\TVP_P2\TVP_P2\TVP.accdb'";
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'G:\New folder\TVP_P2\TVP_P2\TVP.accdb'";
        }
        public void OtvoriKonekciju()
        {
            if (conn != null)
            {
                conn.Open();
            }
        }
        public void ZatvoriKonekciju()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
        public OleDbConnection Conn
        { get { return conn; } set { conn = value; } }
    }
}
