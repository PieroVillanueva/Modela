using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entUsuario
    {
        public int idUsuario { get; set; }
        public string contrasena { get; set; }
        public int dni { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public int edad { get; set; }
        public char sexo { get; set; }
        public string cargo { get; set; }
        public int telefono { get; set; }
        public string correo { get; set; }
        public Boolean habilitar { get; set; }

       
    }
}
