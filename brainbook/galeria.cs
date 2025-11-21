using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brainbook
{
    public partial class galeria : Form

    {
        datosperfil datosperfil = new datosperfil();

        public galeria()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {

            // Cerrar el formulario actual (interfasusuario)
            this.Hide();

            // Crear una instancia del formulario perfil
            interfasusuario perfilForm = new interfasusuario();

            // Mostrar el formulario perfil
            perfilForm.Show();
        }
    }
}
