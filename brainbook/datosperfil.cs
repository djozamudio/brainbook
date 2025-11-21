using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainbook
{
   public  class datosperfil
    {
        public string nombre;
        public string apellido;
        public string sexo;
        public string pais;
        public string talento;
        public DateTime cumpleaños;
        public  Image foto;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Talento { get => talento; set => talento = value; }
        public DateTime Cumplleaños { get => cumpleaños; set => cumpleaños = value; }
        public Image Foto { get => foto; set => foto = value; }
    }
}

