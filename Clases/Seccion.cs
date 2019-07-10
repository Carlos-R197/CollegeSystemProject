using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Clases
{
    public class Seccion
    {
        public Profesor Profesor { get; set; }
        public List<string> NombreEstudiantes { get; set; }
        public int NumeroSeccion { get; set; }
        public string Materia { get; set; }

        public Seccion(Profesor pro, string materia)
        {
            NombreEstudiantes = new List<string>();
            this.Profesor = pro;
            this.Materia = materia;
            this.NumeroSeccion = ObtenerCantidadArchivos() + 1;
            CrearNuevaSeccion();
        }

        public Seccion(Profesor pro, List<string> nombreEstudiantes, int NumeroSeccion, string materia)
        {
            this.Profesor = pro;
            this.NombreEstudiantes = nombreEstudiantes;
            this.NumeroSeccion = NumeroSeccion;
            this.Materia = materia;
        }

        private void CrearNuevaSeccion()
        {
            string filePath = Environment.CurrentDirectory + "\\" + Profesor.Id + "\\" + Materia;
            filePath += "\\Seccion" + NumeroSeccion + ".csv";
            File.WriteAllText(filePath, "Estudiantes" + "," + "Profesor" + "," + "Seccion" + "," + "Materia" + Environment.NewLine);
            File.AppendAllText(filePath, "," + Profesor.Nombre + "," + NumeroSeccion + Environment.NewLine);
        }

        private int ObtenerCantidadArchivos()
        {
            string dir = Environment.CurrentDirectory + "\\" + Profesor.Id + "\\" + Materia;
            string[] archivos = Directory.GetFiles(dir, "*.csv");
            return archivos.Length;
        }

        public void AñadirEstudiante(string nombreEstudiante)
        {
            string filePath = Environment.CurrentDirectory + "\\" + Profesor.Id + "\\" + Materia + "\\Seccion" + NumeroSeccion + ".csv";
            File.AppendAllText(filePath, nombreEstudiante + Environment.NewLine);
            NombreEstudiantes.Add(nombreEstudiante);
        }

        public void EliminarEstudiante(string nombreEstudiante)
        {
            string filePath = Environment.CurrentDirectory + "\\" + Profesor.Id + "\\" + Materia + "\\Seccion" + NumeroSeccion + ".csv";
            NombreEstudiantes.Remove(nombreEstudiante);
            //Borra el archivo y vuelvelo a escribir
            foreach (string nombre in NombreEstudiantes)
            {
                CrearNuevaSeccion();
                File.AppendAllText(filePath, nombre + Environment.NewLine);
            }
        }

    }
}
