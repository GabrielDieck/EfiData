using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clientes
{
    public class ClienteDAL
    {

        public static int Agregar(Clientes pRazonSocial)
        {
            int retorno = 0;
            using (SqlConnection connection = BDComun.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into ListaClientes (RazonSocial, Direccion, RUC, Telefono) values ('{0}', '{1}', '{2}', '{3}')",
                    pRazonSocial.RazonSocial, pRazonSocial.Direccion, pRazonSocial.RUC, pRazonSocial.Telefono), connection);
                retorno = Comando.ExecuteNonQuery();

            }

            return retorno;
        }


    }


}
