using Clientes.Conexion;
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

        public static List<Clientes> BuscarClientes(String pRazonSocial, String pRUC)
        {

            List<Clientes> Lista= new List<Clientes>();
            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {

                SqlCommand comando = new SqlCommand(string.Format(
                    "Select Id, RazonSocial, Direccion, RUC, Telefono from ListaClientes where RazonSocial like '%{0}%' or RUC like '%{1}%'", pRazonSocial, pRUC), conexion);
                
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    Clientes pClientes = new Clientes();
                    pClientes.Id = reader.GetInt32(0);
                    pClientes.RazonSocial = reader.GetString(1);
                    pClientes.Direccion = reader.GetString(2);
                    pClientes.RUC = reader.GetString(3);
                    pClientes.Telefono = reader.GetString(4);

                    Lista.Add(pClientes);
                }
                conexion.Close();
                return Lista;
            }

        }

        public static Clientes ObtenerCliente(Int32 pId)
        {
            
            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {

                Clientes pClientes = new Clientes();
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select Id, RazonSocial, Direccion, RUC, Telefono from ListaClientes where Id={0}", pId), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    pClientes.Id = reader.GetInt32(0);
                    pClientes.RazonSocial = reader.GetString(1);
                    pClientes.Direccion = reader.GetString(2);
                    pClientes.RUC = reader.GetString(3);
                    pClientes.Telefono = reader.GetString(4);

                }
                conexion.Close();
                return pClientes;
            }

        }
        public static int Modificar(Clientes pCliente)
        {
            int retorno = 0;
            using (SqlConnection conexion = BDComun.ObtenerConexion())
            {

                SqlCommand comando = new SqlCommand(string.Format("Update ListaClientes set RazonSocial='{0}', Direccion='{1}', RUC='{2}', Telefono='{3}' where Id={4}",
                    pCliente.RazonSocial, pCliente.Direccion, pCliente.RUC, pCliente.Telefono, pCliente.Id), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }

        public static int Eliminar (Int32 pId)
        {
            int retorno = 0;
            using (SqlConnection conexion= BDComun.ObtenerConexion())
            {

                SqlCommand comando = new SqlCommand(string.Format("Delete from ListaClientes where Id={0}", pId), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;

        }
    }


}
