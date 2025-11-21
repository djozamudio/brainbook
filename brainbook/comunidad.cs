using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace brainbook
{
    
    public partial class comunidad : Form
    {
        
        public comunidad()
        {
            InitializeComponent();
        }

        private void GALERIA_Click(object sender, EventArgs e)
        {
                interfasusuario inus = new interfasusuario();
            inus.label4.Text = "guitarra";
              inus.Show();
            this.Hide();
           
        }
    }
}
