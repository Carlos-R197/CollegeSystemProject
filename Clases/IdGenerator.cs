using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    static class IdGenerator
    {
        public static int GenerarIdEstudiante()
        {
            int id = 1000000;
            List<Estudiante> estudiantes = Estudiante.ObtenerListaEstudiantes();
            foreach (Estudiante est in estudiantes)
            {
                id++;
            }

            return id;
        }
    }
}
