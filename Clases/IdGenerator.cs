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

        public static string GenerarIdProfesor()
        {
            string id = "002-" + DateTime.Now.Year + "-";
            int counter = 1;

            foreach (Profesor pro in Profesor.ObtenerListaProfesores())
            {
                counter++;
            }

            id += counter.ToString().PadLeft(4, '0');
            return id;
        }
    }
}
