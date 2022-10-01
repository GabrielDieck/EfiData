namespace Clientes
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autentificacion auten = new Autentificacion();
            auten.Show();

        }

        private void registrarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Usuarios Registro = new Registro_Usuarios();
            Registro.Show();

        }

        private void consultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda busqueda = new Busqueda();
            busqueda.Show();   


        }

        private void crearNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisHot regisrico = new RegisHot();
            regisrico.Show();
           
        }
    }
}
