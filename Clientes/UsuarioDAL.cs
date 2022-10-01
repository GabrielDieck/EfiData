using Clientes.Conexion;
using System.Data.SqlClient;

namespace Clientes
{
    class UsuarioDAL
    {

        public static int CrearCuentas(string pUsuario, string pContraseña)
        {

            int resultado = 0;
            SqlConnection connection = BDComun.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("Insert into Usuarios (Nombre, Contraseña) values ('{0}', PwdEncrypt('{1}') )", pUsuario, pContraseña), connection);

            resultado = Comando.ExecuteNonQuery();
            connection.Close();
            return resultado;

        }

        public static int Autentificar(String pUsuarios, String pContraseña)
        {

            int resultado = -1;

            SqlConnection conexion = BDComun.ObtenerConexion();

            SqlCommand comando = new SqlCommand(string.Format("Select * From Usuarios Where Nombre = '{0}' and PwdCompare('{1}',Contraseña) = 1", pUsuarios, pContraseña), conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                resultado = 50;

            }

            conexion.Close();
            return resultado;

        }


    }
}
