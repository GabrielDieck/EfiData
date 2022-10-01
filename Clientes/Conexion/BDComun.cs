using System.Data.SqlClient;

namespace Clientes.Conexion
{
    public class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection("Data source=192.168.0.20; Initial Catalog=BDClientes; User Id=Comun; Password=password");
            conn.Open();

            return conn;

        }
    }
}
