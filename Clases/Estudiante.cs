using System;
using System.IO;
using System.Collections.Generic;

namespace Clases
{
    public class Estudiante
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        private string  Password { get; set; }

        public Estudiante(int id, string password, string nombre, string carrera)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Carrera = carrera;
            this.Password = password;
        }

        public static void CrearArchivo()
        {
            string filePath = Environment.CurrentDirectory + "\\Estudiantes.csv";

            if (!File.Exists(filePath))
            {
                File.AppendAllText(filePath, "ID" + "," + "Nombre" + "," + "Carrera" + "," + "Password" + Environment.NewLine);
            }
        }

        public static void AñadirEstudiante(Estudiante est)
        {
            string filePath = Environment.CurrentDirectory + "\\Estudiantes.csv";
            File.AppendAllText(filePath, est.ID + "," + est.Nombre + "," + est.Carrera + "," + est.Password +  Environment.NewLine);
        }

        public static void EliminarEstudiante(int id)
        {
            List<Estudiante> estudiantes = ObtenerListaEstudiantes();
            foreach (Estudiante est in estudiantes)
            {
                if (id == est.ID)
                {
                    estudiantes.Remove(est);
                    CrearArchivo();
                    for (int i = 0; i < estudiantes.Count; i++)
                    {
                        AñadirEstudiante(est);
                    }
                }

            }
        }

        public static List<Estudiante> ObtenerListaEstudiantes()
        {
            string filePath = Environment.CurrentDirectory + "\\Estudiantes.csv";
            List<Estudiante> estudiantes = new List<Estudiante>();
            int id;
            string nombre, carrera, password;
            string[] lineas = File.ReadAllLines(filePath);
            string[] datos;

            for (int i = 1; i < lineas.Length; i++)
            {
                datos = lineas[i].Split(',');
                id = Int32.Parse(datos[0]);
                nombre = datos[1];
                carrera = datos[2];
                password = datos[3];
                estudiantes.Add(new Estudiante(id, password, nombre, carrera));
            }
            return estudiantes;
        }

        public static bool VerificarEstudianteExiste(int id, string password)
        {
            bool estudianteExiste = false;

            List<Estudiante> estTemp = ObtenerListaEstudiantes();
            for (int i = 0; i < estTemp.Count; i++)
            {
                if (estTemp[i].ID == id)
                    if (estTemp[i].Password == password)
                        estudianteExiste = true;
            }
            return estudianteExiste;
        }

        public static bool VerificarIdExiste(int id)
        {
            bool idExiste = false;

            List<Estudiante> estTemp = ObtenerListaEstudiantes();
            for (int i = 0; i < estTemp.Count; i++)
            {
                if (estTemp[i].ID == id)
                {
                    idExiste = true;
                    break;
                }
            }
            return idExiste;

        }

        public static bool VerificarPassword(string password)
        {
            bool passwordExiste = false;

            List<Estudiante> estTemp = ObtenerListaEstudiantes();
            for (int i = 0; i < estTemp.Count; i++)
            {
                if (estTemp[i].Password == password)
                {
                    passwordExiste = true;
                    break;
                }
            }
            return passwordExiste;
        }
    }
}
