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
    public partial class inicio : Form
    {
        private datosregistro drg; // Instancia de datosregistro
        public inicio()
        {
            InitializeComponent();
            drg = new datosregistro();

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            registro regis = new registro();
            regis.Show();
            this.Hide();
        }

        private void Sesion_Click(object sender, EventArgs e)
        {
            Iniciosesion ini = new Iniciosesion(drg);
            ini.Show();
            this.Hide();
        }
    }
}
