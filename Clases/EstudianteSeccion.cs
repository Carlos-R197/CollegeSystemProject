using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class EstudianteSeccion
    {
        public string Nombre { get; set; }
        public int Cal { get; set; }

        public EstudianteSeccion(string nombre)
        {
            this.Nombre = nombre;
        }

        public EstudianteSeccion(string nombre, int Cal)
        {
            this.Nombre = nombre;
            this.Cal = Cal;
        }
    }
}
