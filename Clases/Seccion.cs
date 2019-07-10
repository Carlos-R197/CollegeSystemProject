using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Clases
{
    public class Seccion
    {
        public Profesor Profesor { get; set; }
        public List<EstudianteSeccion> Estudiantes { get; set; }
        public List<int> Calificaciones { get; set; }
        public int NumeroSeccion { get; set; }
        public string Materia { get; set; }

        public Seccion(Profesor pro, string materia)
        {
            Estudiantes = new List<EstudianteSeccion>();
            this.Profesor = pro;
            this.Materia = materia;
            this.NumeroSeccion = ObtenerCantidadArchivos() + 1;
            CrearNuevaSeccion();
        }

        public Seccion(Profesor pro, List<EstudianteSeccion> estudiantes, int NumeroSeccion, string materia)
        {
            this.Profesor = pro;
            this.Estudiantes = estudiantes;
            this.NumeroSeccion = NumeroSeccion;
            this.Materia = materia;
        }

        private void CrearNuevaSeccion()
        {
            string filePath = Environment.CurrentDirectory + "\\" + Profesor.Id + "\\" + Materia;
            filePath += "\\Seccion" + NumeroSeccion + ".csv";
            File.WriteAllText(filePath, "Estudiantes" + "," + "Calificaciones" + "," + "Profesor" + "," + "Seccion" + "," + "Materia" + Environment.NewLine);
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
            Estudiantes.Add(new EstudianteSeccion(nombreEstudiante));
        }

        public void AñadirCalificacion(EstudianteSeccion est)
        {
            string filePath = Environment.CurrentDirectory + "\\" + Profesor.Id + "\\" + Materia + "\\Seccion" + NumeroSeccion + ".csv";
            string[] lineas = File.ReadAllLines(filePath);
            string[] datos;
            CrearNuevaSeccion();
            for (int i = 1; i < lineas.Length; i++)
            {
                datos = lineas[i].Split(',');
                if (datos[0].Equals(est.Nombre))
                {
                    foreach (EstudianteSeccion estudiante in Estudiantes)
                    {
                        if (est.Nombre.Equals(estudiante.Nombre))
                        {
                            Estudiantes.Remove(estudiante);
                            break;
                        }
                    }
                    Estudiantes.Add(new EstudianteSeccion(est.Nombre, est.Cal));
                    break;
                }
            }

            foreach (EstudianteSeccion estudiante in Estudiantes)
            {
                File.AppendAllText(filePath, estudiante.Nombre + "," + estudiante.Cal + Environment.NewLine);
            }
        }

        public void EliminarEstudiante(string nombreEstudiante)
        {
            string filePath = Environment.CurrentDirectory + "\\" + Profesor.Id + "\\" + Materia + "\\Seccion" + NumeroSeccion + ".csv";
            foreach (EstudianteSeccion est in Estudiantes)
            {
                if (est.Nombre.Equals(nombreEstudiante))
                {
                    Estudiantes.Remove(est);
                    break;
                }
            }
            //Borra el archivo y vuelvelo a escribir
            CrearNuevaSeccion();
            foreach (EstudianteSeccion estudiante in Estudiantes)
            {
                File.AppendAllText(filePath, estudiante.Nombre + "," + estudiante.Cal + Environment.NewLine);
            }
        }

    }
}
