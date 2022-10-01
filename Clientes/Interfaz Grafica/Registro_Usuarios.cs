namespace Clientes
{
    public partial class Registro_Usuarios : Form
    {
        public Registro_Usuarios()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtContraseña.Text == txtConfirmar.Text)
            {

                if (UsuarioDAL.CrearCuentas(txtUsuario.Text, txtContraseña.Text) > 0)
                {
                    MessageBox.Show("Usuario registrado Exitosamente!");
                }
                else
                    MessageBox.Show("Error al registrar al usuario, Verifique los datos.");

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
