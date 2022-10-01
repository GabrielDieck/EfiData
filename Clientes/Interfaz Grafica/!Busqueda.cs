using Clientes.Conexion;
using System.Data;
using System.Data.SqlClient;

namespace Clientes
{
    public partial class Busqueda : Form
    {

        public Busqueda()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Busqueda_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtRazonSocial.Text + txtRUC.Text == "")
            {

                string query = "Select * from ListaClientes";
                SqlCommand comando = new SqlCommand(query, BDComun.ObtenerConexion());
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvlista.DataSource = tabla;
                DataGridViewColumn Column = dgvlista.Columns["Id"];
                Column.Visible = false;

            }

            else
            {

                string query = "Select * from ListaClientes where RazonSocial like '" + txtRazonSocial.Text + "' or RUC like '" + txtRUC.Text + "'";
                SqlCommand comando = new SqlCommand(query, BDComun.ObtenerConexion());
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvlista.DataSource = tabla;
                DataGridViewColumn Column = dgvlista.Columns["Id"];
                Column.Visible = false;

            }


        }
        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = BDComun.ObtenerConexion();
            String query = "select * from ListaClientes where RazonSocial like '" + txtRazonSocial.Text + "' or RUC like '"+ txtRUC.Text +"'";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);


            DataSet data = new DataSet();

            ada.Fill(data, "ListaClientes");

            dgvlista.DataSource = data;
            dgvlista.DataMember = "ListaClientes";
            DataGridViewColumn Column = dgvlista.Columns["Id"];
            Column.Visible = false;

        }

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
