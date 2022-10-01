using Clientes.Conexion;
using System.Data.SqlClient;

namespace Clientes
{
    public class Clientes

    {
        public Int64 Id { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string RUC { get; set; }
        public string Telefono { get; set; }

        public Clientes() { }


        public Clientes(Int64 pId, String pRazonSocial, String pDireccion, String pRUC, String pTelefono)

        {
            this.Id = pId;
            this.RazonSocial = pRazonSocial;
            this.Direccion = pDireccion;
            this.RUC = pRUC;
            this.Telefono = pTelefono;


        }

    }
}
