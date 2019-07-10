using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Clases
{
    public static class SeccionManager
    {
        public static List<Seccion> ObtenerSecciones(string materia, Profesor profesor)
        {
            List<Seccion> secciones = new List<Seccion>();
            List<string> nombreEstudiantes = new List<string>();
            string filepath = Environment.CurrentDirectory + "\\" + profesor.Id + "\\" + materia;
            string[] lineas, datos;

            foreach (string file in Directory.GetFiles(filepath, "*.csv"))
            {
                lineas = File.ReadAllLines(file);
                for (int i = 1; i < lineas.Length; i++)
                {
                    datos = lineas[i].Split(',');
                    nombreEstudiantes.Add(datos[0]);
                }
                int seccion = Int32.Parse(lineas[1].Split(',')[2]);

                secciones.Add(new Seccion(profesor, nombreEstudiantes, seccion, materia));
            }

            return secciones;
        }

        public static Seccion ObtenerPrimeraSeccion(string materia, Profesor profesor)
        {
            Seccion sec;
            string filePath = Environment.CurrentDirectory + "\\" + profesor.Id + "\\" + materia;
            if (Directory.GetFiles(filePath, "*.csv").Length > 0)
            {
                filePath += "\\Seccion1.csv"; 
                string[] lineas = File.ReadAllLines(filePath);
                List<string> estudiantes = new List<string>();
                for (int i = 1; i < lineas.Length; i++)
                {
                    string[] datos = lineas[i].Split(',');
                    estudiantes.Add(datos[0]);

                }
                sec = new Seccion(profesor, estudiantes, 1, materia);
            }
            else
                sec = null;


            return sec;
        }

        public static List<string> ObtenerListaEstudiantes(string materia, Profesor profesor, int seccion)
        {
            List<string> estudiantes = new List<string>();
            string filePath = Environment.CurrentDirectory + "\\" + profesor.Id + "\\" + materia + "\\Seccion" + seccion + ".csv";
            string[] lineas = File.ReadAllLines(filePath);
            string[] datos;

            for (int i = 1; i < lineas.Length; i++)
            {
                datos = lineas[i].Split(',');
                estudiantes.Add(datos[0]);
            }

            return estudiantes;
        }
    }
}
