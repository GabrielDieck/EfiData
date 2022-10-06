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

        public Clientes ClienteSeleccionado { get; set; }

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
            dgvlista.DataSource = ClienteDAL.BuscarClientes(txtRazonSocial.Text, txtRUC.Text);
            DataGridViewColumn Column = dgvlista.Columns["Id"];
            Column.Visible = false;



            if (txtRazonSocial.Text + txtRUC.Text == "")
            {

                string query = "Select * from ListaClientes";
                SqlCommand comando = new SqlCommand(query, BDComun.ObtenerConexion());
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvlista.DataSource = tabla;
                Column.Visible = false;

            }


        }

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conec = BDComun.ObtenerConexion();
            String query = "select * from ListaClientes where RUC like '%" + txtRUC.Text + "%'";
            SqlDataAdapter adap = new SqlDataAdapter(query, conec);


            DataSet datos = new DataSet();

            adap.Fill(datos, "ListaClientes");

            dgvlista.DataSource = datos;
            dgvlista.DataMember = "ListaClientes";
            DataGridViewColumn Column = dgvlista.Columns["Id"];
            Column.Visible = false;
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = BDComun.ObtenerConexion();
            String query = "select * from ListaClientes where RazonSocial like '%" + txtRazonSocial.Text + "%'";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);


            DataSet data = new DataSet();

            ada.Fill(data, "ListaClientes");

            dgvlista.DataSource = data;
            dgvlista.DataMember = "ListaClientes";
            DataGridViewColumn Column = dgvlista.Columns["Id"];
            Column.Visible = false;

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if(dgvlista.SelectedRows.Count==1)
            {

                Int64 Id = Convert.ToInt64 (dgvlista.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = ClienteDAL.ObtenerCliente((int)Id);
                this.Close();
            }
            else
            {

                MessageBox.Show("No has seleccionado ningun cliente");

            }
            
            
            
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
