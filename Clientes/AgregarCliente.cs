namespace Clientes
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }
        public Clientes ClienteActual { get; set; }
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
            Cliente.RazonSocial = txtrazonsocial.Text;
            Cliente.Direccion = txtdireccion.Text;
            Cliente.RUC = txtruc.Text;
            Cliente.Telefono = txtcelular.Text;

            int resultado = ClienteDAL.Agregar(Cliente);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();
            }


            else
            {
                MessageBox.Show("No se pudo guardar los datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void controlBotonRUC()
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
            txtrazonsocial.Focus();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Busqueda pBusqueda = new Busqueda();
            pBusqueda.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro_Usuarios RegistroUsuarios = new Registro_Usuarios();
            RegistroUsuarios.Show();
        }

        private void Regis_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            txtrazonsocial.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
        }

        private void txtrazonsocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                txtruc.Focus();

            }
        }

        private void txtruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                txtcelular.Focus();
            }
        }

        private void txtcelular_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtcelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                txtdireccion.Focus();
            }
        }

        private void txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Clientes Cliente = new Clientes();
                Cliente.RazonSocial = txtrazonsocial.Text;
                Cliente.Direccion = txtdireccion.Text;
                Cliente.RUC = txtruc.Text;
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



        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            Clientes pCliente = new Clientes();
            pCliente.RazonSocial = txtrazonsocial.Text;
            pCliente.Direccion = txtdireccion.Text;
            pCliente.RUC = txtruc.Text;
            pCliente.Telefono = txtcelular.Text;
            pCliente.Id = ClienteActual.Id;

            int resultado = ClienteDAL.Modificar(pCliente);

            if(resultado >0)
            {

                MessageBox.Show("Cliente Modificado Correctamente", "Cliente Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnGuardar.Enabled = true;
            }
            
            else
            {

                MessageBox.Show("Error al Modificar Cliente","Ha ocurrido un problema", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Busqueda pBusqueda = new Busqueda();
            pBusqueda.ShowDialog();

            if (pBusqueda.ClienteSeleccionado != null)
            {

                ClienteActual=pBusqueda.ClienteSeleccionado;
                txtrazonsocial.Text = pBusqueda.ClienteSeleccionado.RazonSocial;
                txtdireccion.Text = pBusqueda.ClienteSeleccionado.Direccion;
                txtruc.Text = pBusqueda.ClienteSeleccionado.RUC;
                txtcelular.Text = pBusqueda.ClienteSeleccionado.Telefono;

                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

            }
        }
        
        void limpiar()
        {
            txtrazonsocial.Clear();
            txtdireccion.Clear();
            txtruc.Clear();
            txtcelular.Clear();
            txtrazonsocial.Focus();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            txtrazonsocial.Focus();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar este Cliente?", "Esta seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int resultado = ClienteDAL.Eliminar((int)ClienteActual.Id);
                if (resultado > 0)
                {

                    MessageBox.Show("Cliente Eliminado Correctamente", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled= false;
                    btnGuardar.Enabled = true;
                }

                else
                {

                    MessageBox.Show("Error al Eliminar Cliente", "Ha ocurrido un problema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }
    }

}