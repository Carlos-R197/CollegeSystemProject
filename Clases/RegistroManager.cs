using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Clases
{
    public static class RegistroManager
    {
        public static List<Registro> registros = new List<Registro>();

        //Guarda la informacion de los registros basado en el Trimestre
        public static void GuardarTrimestreEspecifico(int idEstudiante, int trimestre)
        {
            //Carpeta donde se guardara la informacion del estudiante por trimestre
            string filePath = Environment.CurrentDirectory + "\\" + idEstudiante;
            filePath += "\\Trimestre" + trimestre + ".csv";

            if (File.Exists(filePath))
                File.Delete(filePath);

            File.AppendAllText(filePath, "Materia" + "," + "Creditos" + "," + "Nota" + Environment.NewLine);
            foreach (Registro reg in registros)
            {
                File.AppendAllText(filePath, reg.subject + "," + reg.credValue + "," + reg.grade + Environment.NewLine);
            }
        }
        //Determina la cantidad de archivos csv en una carpeta
        public static int DeterminarCantidadArchivos(string directorio)
        {
            string[] files = Directory.GetFiles(directorio, "*.csv");
            return files.Length;
        }
        //Obtiene el path de uno de los archivos que guardan los registros con un id y el trimestre
        public static string ObtenerPathDeArchivo(int id, int trimestre)
        {
           string path = Environment.CurrentDirectory + "\\" + id + "\\" + "Trimestre" + trimestre + ".csv";
           return path;
        }
        //Llena la lista de registros en base a un archivo
        public static void LlenarListaRegistro(string path)
        {
            List<Registro> regs = new List<Registro>();
            string[] lineas = File.ReadAllLines(path);
            string[] data;

            for (int i = 1; i < lineas.Length; i++)
            {
                data = lineas[i].Split(',');
                regs.Add(new Registro(data[0], data[1], data[2]));
            }

            registros = regs;
        }
    }
}
