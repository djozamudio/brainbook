using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brainbook
{
   public class datosregistro
    {
        public string nombre;
        public string contraseña;
        public string correo;
        public string numero;
        public string estrato;
        public DateTime fecha;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Estrato { get => estrato; set => estrato = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
