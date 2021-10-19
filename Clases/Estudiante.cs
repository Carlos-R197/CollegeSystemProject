using System;
using System.IO;
using System.Collections.Generic;

namespace Clases
{
    public class Estudiante
    {
        public string ID { get; private set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        private string Password { get; set; }
        public int Trimestre { get; set; }

        private Estudiante(string id, string password, string nombre, string carrera)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Carrera = carrera;
            this.Password = password;
        }
        public Estudiante(string password, string nombre, string carrera)
        {
            this.ID = IdGenerator.GenerarIdEstudiante();
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
        private static void ReescribirArchivo()
        {
            string filePath = Environment.CurrentDirectory + "\\Estudiantes.csv";

            File.WriteAllText(filePath, "ID" + "," + "Nombre" + "," + "Carrera" + "," + "Password" + Environment.NewLine);

        }
        public static string AñadirEstudiante(Estudiante est)
        {
            string filePath = Environment.CurrentDirectory + "\\Estudiantes.csv";
            string id = IdGenerator.GenerarIdEstudiante();
            File.AppendAllText(filePath, id + "," + est.Nombre + "," + est.Carrera + "," + est.Password + Environment.NewLine);
            Directory.CreateDirectory(Environment.CurrentDirectory + "\\" + id);
            est.ID = id;
            return id;
        }
        public static void EliminarEstudiante(string id)
        {
            List<Estudiante> estudiantes = ObtenerListaEstudiantes();
            foreach (Estudiante est in estudiantes)
            {
                if (id.Equals(est.ID))
                {
                    //Antes de remover al estudiante de la lista ponlo en el archivo de estudiantes borrados.
                    string filePath = Environment.CurrentDirectory + "\\Estudiantes_temp.csv";
                    File.AppendAllText(filePath, id + "," + est.Nombre + "," + est.Carrera + "," + est.Password + Environment.NewLine);

                    estudiantes.Remove(est);
                    break;
                }
            }

            Directory.Delete(Environment.CurrentDirectory + "\\" + id, true);
            ReescribirArchivo();
            for (int i = 0; i < estudiantes.Count; i++)
            {
                AñadirEstudiante(estudiantes[i]);
            }
        }
        public static List<Estudiante> ObtenerListaEstudiantes()
        {
            string filePath = Environment.CurrentDirectory + "\\Estudiantes.csv";
            List<Estudiante> estudiantes = new List<Estudiante>();

            if (File.Exists(filePath))
            {
                string[] lineas = File.ReadAllLines(filePath);
                string[] datos;
                //Empezando desde la segunda linea lee los datos y guardarlo como elemento en la lista.
                for (int i = 1; i < lineas.Length; i++)
                {
                    datos = lineas[i].Split(',');
                    estudiantes.Add(new Estudiante(datos[0], datos[3], datos[1], datos[2]));
                }
            }

            return estudiantes;
        }
        public static bool VerificarEstudianteExiste(string id, string password)
        {
            bool estudianteExiste = false;

            foreach (Estudiante est in ObtenerListaEstudiantes())
            {
                if (est.ID.Equals(id))
                    if (est.Password.Equals(password))
                    {
                        estudianteExiste = true;
                        break;
                    }
            }
            return estudianteExiste;
        }
        public static bool VerificarIdExiste(string id)
        {
            bool idExiste = false;

            List<Estudiante> estTemp = ObtenerListaEstudiantes();
            for (int i = 0; i < estTemp.Count; i++)
            {
                if (estTemp[i].ID.Equals(id))
                {
                    idExiste = true;
                    break;
                }
            }
            return idExiste;

        }
        public static bool VerificarPasswordExiste(string password)
        {
            bool passwordExiste = false;

            foreach (Estudiante est in ObtenerListaEstudiantes())
            {
                if (est.Password == password)
                {
                    passwordExiste = true;
                    break;
                }
            }

            return passwordExiste;
        }
    }


}
