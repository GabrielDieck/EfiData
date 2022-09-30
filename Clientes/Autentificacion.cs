using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                this.Hide();
                Regis busqueda = new Regis();
                busqueda.ShowDialog();

            }
            else
                MessageBox.Show("Verifique los datos");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
