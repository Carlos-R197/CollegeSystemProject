using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    static class IdGenerator
    {
        public static string GenerarIdEstudiante()
        {
            string id = "10";
            int counter = 1;

            foreach (Estudiante est in Estudiante.ObtenerListaEstudiantes())
            {
                counter++;
            }

            id += counter;
            return id;
        }

        public static string GenerarIdProfesor()
        {
            string id = "20";
            int counter = 1;

            foreach (Profesor pro in Profesor.ObtenerListaProfesores())
            {
                counter++;
            }

            id += counter;
            return id;
        }
    }
}
