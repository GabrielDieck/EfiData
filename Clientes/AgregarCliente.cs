namespace Clientes
{
    public partial class Regis : Form
    {
        public Regis()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clientes Cliente = new Clientes();
            Cliente.RazonSocial = txtruc.Text;
            Cliente.Direccion = txtdireccion.Text;
            Cliente.RUC = txtrazonsocial.Text;
            Cliente.Telefono = txtcelular.Text;

            int resultado = ClienteDAL.Agregar(Cliente);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No se pudo guardar los datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtdireccion_TextChanged(object sender, EventArgs  e)
        {

        }

        private void txtruc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtrazonsocial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Busqueda pBusqueda = new Busqueda();
            pBusqueda.ShowDialog();
        }
    }
}