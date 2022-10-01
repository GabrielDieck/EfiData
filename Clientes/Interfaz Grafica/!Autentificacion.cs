namespace Clientes
{
    public partial class Autentificacion : Form
    {
        public Autentificacion()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (UsuarioDAL.Autentificar(txtUsuario.Text, txtContraseña.Text) > 0)
            {

                Principal menuprincipal = new Principal();
                menuprincipal.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Verifique los datos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Autentificacion_Load(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (UsuarioDAL.Autentificar(txtUsuario.Text, txtContraseña.Text) > 0)
                {

                    Principal menuprincipal = new Principal();
                    menuprincipal.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Verifique los datos");
            }


        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                txtContraseña.Focus();

            }
        }
    }

}
