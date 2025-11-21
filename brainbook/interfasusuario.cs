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
    public partial class interfasusuario : Form
    {
        galeria galer = new galeria();
        comunidad comunidad = new comunidad();
        public interfasusuario()
        {
            InitializeComponent();

        }

        private void EDITAR_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario actual (interfasusuario)
            this.Close();

            // Crear una instancia del formulario perfil
            perfil perfilForm = new perfil();

            // Mostrar el formulario perfil
            perfilForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IDEA.Text = PUBL.Text;
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
                    // Obtiene el nombre del archivo de la ruta completa
                    string nombreArchivo = Path.GetFileName(rutaImagen);

                    // Verifica si el nombre del archivo contiene el nombre específico
                    if (!nombreArchivo.Contains("pistola"))
                    {
                        // Carga la imagen en el PictureBox
                        picturePUBLI.Image = Image.FromFile(rutaImagen);
                        picturePUBLI.SizeMode = PictureBoxSizeMode.StretchImage;

                        // Asigna la imagen al PictureBox en la galería también
                        galer.pictureBox1.Image = picturePUBLI.Image;
                        galer.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("No se permite subir por contenido violento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GALERIA_Click(object sender, EventArgs e)
        {
            galer.Show();
            this.Hide();

        }

        private void AMIGOS_Click(object sender, EventArgs e)
        {

        }

        private void COMUNIDADES_Click(object sender, EventArgs e)
        {
            comunidad.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
