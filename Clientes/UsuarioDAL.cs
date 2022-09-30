using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clientes
{
    class UsuarioDAL
    {

        public static int CrearCuentas(string pUsuario, string pContraseña)
        {

            int resultado = 0;
            SqlConnection connection = BDComun.ObtenerConexion();
            SqlCommand Comando = new SqlCommand(string.Format("SET ANSI_WARNINGS OFF;Insert into Usuarios (Nombre, Contraseña) values ('{0}', PwdEncrypt('{1}') );SET ANSI_WARNINGS ON", pUsuario, pContraseña), connection);

            resultado = Comando.ExecuteNonQuery();
            connection.Close();
            return resultado;

        }

    }
}
