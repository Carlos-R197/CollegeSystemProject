using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Clases
{
    public static class RegistroManager
    {
        public static List<Registro> registros = new List<Registro>();

        public static void GuardarTrimestre(int idEstudiante)
        {
            //Carpeta donde se guardara la informacion del estudiante por trimestre
            string filePath = Environment.CurrentDirectory + "\\" + idEstudiante;
            filePath += "\\Trimestre" + (DeterminarCantidadArchivos(filePath) + 1) + ".csv";

            File.AppendAllText(filePath, "Materia" + "," + "Creditos" + "," + "Nota" + Environment.NewLine);
            foreach (Registro reg in registros)
            {
                File.AppendAllText(filePath, reg.subject + "," + reg.credValue + "," + reg.grade + Environment.NewLine);
            }

        }
        private static int DeterminarCantidadArchivos(string directorio)
        {
            string[] files = Directory.GetFiles(directorio, "*.csv");
            return files.Length;
        }

        public static string ObtenerPathDeArchivo(int id, int trimestre)
        {
           string path = Environment.CurrentDirectory + "\\" + id + "\\" + "Trimestre" + trimestre + ".csv";
           return path;
        }
    }
}
