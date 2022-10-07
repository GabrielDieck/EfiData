using System.Windows.Forms;
using System.Web;

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
            Autentificacion auten = new Autentificacion();
            auten.Show();
            this.Close();

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
            AgregarCliente AgregarCliente = new AgregarCliente();
            AgregarCliente.Show();
            
           
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Example_Click(object sender, EventArgs e)
        {
            AgregarCliente agregar = new AgregarCliente();
            agregar.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Registro_Usuarios usuarios = new Registro_Usuarios();
            usuarios.ShowDialog();
        }

        private void fotoExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fotoCrear_Click(object sender, EventArgs e)
        {
            AgregarCliente agregar = new AgregarCliente();
            agregar.ShowDialog();
        }

        private void fotoConsultar_Click(object sender, EventArgs e)
        {
            Busqueda busqueda = new Busqueda();
            busqueda.ShowDialog();
        }

        private void fotoUsuario_Click(object sender, EventArgs e)
        {
            Registro_Usuarios usuarios = new Registro_Usuarios();
            usuarios.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Busqueda busqueda = new Busqueda();
            busqueda.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
