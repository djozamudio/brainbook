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
    public partial class registro : Form
    {
        datosregistro drg = new datosregistro();
        Iniciosesion ini;
        Random Random = new Random();
        public registro()
        {
            InitializeComponent();
            ini = new Iniciosesion(drg);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            drg.Nombre = Nombre.Text;
            drg.Contraseña = contraseña.Text;
            drg.Correo = Correo.Text;
            drg.Numero = numero.Text;
            dateTimePicker1_ValueChanged(sender, e);
           
            // Mostrar el código en un MessageBox
        }
        void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada
            drg.Fecha = dateTimePicker1.Value;

            // Calcular la edad actual
            int edad = DateTime.Today.Year - drg.Fecha.Year;

            // Restar un año si aún no ha cumplido el aniversario de su cumpleaños este año
            if (DateTime.Today < drg.Fecha.AddYears(edad))
            {
                edad--;
            }
            if (edad < 18)
            {
                MessageBox.Show("Debe seleccionar una fecha de nacimiento que cumpla con al menos 18 años de edad.", "Error de fecha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Puedes establecer la fecha seleccionada en una fecha predeterminada aquí si lo deseas
                // Por ejemplo:
                // dateTimePicker1.Value = DateTime.Today.AddYears(-18); // Establecer la fecha hace 18 años      
            }
            else 
            {
                int codigo = Random.Next(100000, 999999);
                MessageBox.Show("Tu código de verificación es: " + codigo.ToString(), "Código", MessageBoxButtons.OK);
                string codigoverificacion = codigo.ToString();
               
                string codigoIngresado = Microsoft.VisualBasic.Interaction.InputBox("Por favor ingrese el código de verificación:", "Código de Verificación", "");

                // Verificar si el código ingresado coincide con el código de verificación generado
                if (codigoIngresado == codigoverificacion)
                {
                    // Código correcto
                    MessageBox.Show("¡Código de verificación correcto! Registro completado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ini.Show();
                    this.Hide();

                }
                else
                {
                    // Código incorrecto
                    MessageBox.Show("Código de verificación incorrecto. Por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
