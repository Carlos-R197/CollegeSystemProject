using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    static class IdGenerator
    {
        public static string GenerarIdEstudiante()
        {
            string id = "001-" + DateTime.Now.Year + "-";
            int counter = 1;

            foreach (Estudiante est in Estudiante.ObtenerListaEstudiantes())
            {
                counter++;
            }

            id += counter.ToString().PadLeft(4, '0');
            return id;
        }
    }
}
