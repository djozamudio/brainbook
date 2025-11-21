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
    public partial class Iniciosesion : Form
    {
      
        datosregistro drg;
        perfil perf = new perfil();

        public Iniciosesion(datosregistro datos)
        {
            InitializeComponent();
            drg = datos;
        }
       
        private void Sesion_Click(object sender, EventArgs e)
        {
            if (drg.Nombre == Nombre.Text && drg.Contraseña == contraseña.Text)
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí puedes abrir el formulario principal o realizar otras acciones
                perf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
