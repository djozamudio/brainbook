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
    public partial class perfil : Form
    {
        datosperfil dpf = new datosperfil();
        interfasusuario inus = new interfasusuario();
        public perfil()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crea un cuadro de diálogo para seleccionar un archivo de imagen
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*";
            openFileDialog.Title = "Seleccionar imagen";

            // Muestra el cuadro de diálogo y espera a que el usuario seleccione un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta del archivo seleccionado
                string rutaImagen = openFileDialog.FileName;

                try
                {
                    // Carga la imagen en el PictureBox
                    pictureBox1.Image = Image.FromFile(rutaImagen);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void GUARDAR_Click(object sender, EventArgs e)
        {
            dpf.Nombre = Nombres.Text;
            dpf.Apellido = Apellidos.Text;
            dpf.Sexo = Genero.Text;
            dpf.Pais = pais.Text;
            dpf.talento = Talento.Text;
            dpf.foto = pictureBox1.Image;
            dateTimePicker1_ValueChanged(sender, e);
            MessageBox.Show($"Nombre: {dpf.Nombre}, Apellido: {dpf.Apellido}, Sexo: {dpf.Sexo}, País: {dpf.Pais}, Talento: {dpf.talento}");
            inus.pictureBox1.Image = dpf.foto;
            inus.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            inus.Nombre.Text = dpf.Nombre;
            inus.Apellido.Text = dpf.Apellido;
            inus.Talento.Text = dpf.Talento;


        }
        void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Obtener la fecha seleccionada
            dpf.cumpleaños = Cumpleaños.Value;

            // Calcular la edad actual
            int edad = DateTime.Today.Year - dpf.cumpleaños.Year;

            // Verificar si la edad es menor de 18 años
            if (edad > 18)
            {
                MessageBox.Show("Esta ingresando una fecha que indica que es mayor de edad.", "Error de fecha", MessageBoxButtons.OK);
                // Puedes establecer la fecha seleccionada en una fecha predeterminada aquí si lo deseas
                // Por ejemplo:
                // dateTimePicker1.Value = DateTime.Today.AddYears(-18); // Establecer la fecha hace 18 años      
            }
            else
            {
                MessageBox.Show("¡Cambios realizados con exito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                inus.Show();
                this.Hide();

            }


        }
    }

}
