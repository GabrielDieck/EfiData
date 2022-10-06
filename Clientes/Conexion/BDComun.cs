using System.Data.SqlClient;
using Clientes.Properties;
using System.Configuration;

namespace Clientes.Conexion
{
    public class BDComun
    {
        public static string ObtenerString()
        {

            return Settings.Default.conexion;

        }

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection(ObtenerString());
            conn.Open();

            return conn;

        }
    }
}
