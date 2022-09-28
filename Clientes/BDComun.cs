using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clientes
{
    public class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection("Data source=DESKTOP-3AU5ED1\\SERVER_PROYEC; Initial Catalog=BDClientes; User Id=Comun; Password=password");
            conn.Open();

            return conn;

        }
    }
}
