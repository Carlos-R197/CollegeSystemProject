using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Clases
{
    public class Profesor
    {
        public string Id { get; private set; }
        public string Nombre { get; set; }
        private string Password { get; set; }

        private Profesor(string id, string nombre, string password)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Password = password;
        }
        public Profesor(string nombre, string password)
        {
            this.Id = IdGenerator.GenerarIdProfesor();
            this.Nombre = nombre;
            this.Password = password;
        }

        public Profesor(string nombre)
        {
            this.Nombre = nombre;
        }
        public static void CrearArchivo()
        {
            string filePath = Environment.CurrentDirectory + "\\Profesores.csv";

            if (!File.Exists(filePath))
            {
                File.AppendAllText(filePath, "ID" + "," + "Nombre" +  "," + "Password" + Environment.NewLine);
            }
        }
        private static void ReescribirArchivo()
        {
            string filePath = Environment.CurrentDirectory + "\\Profesores.csv";

            File.WriteAllText(filePath, "ID" + "," + "Nombre" + "," + "Password" + Environment.NewLine);

        }
        public static string AñadirProfesor(Profesor pro)
        {
            string filePath = Environment.CurrentDirectory + "\\Profesores.csv";
            string id = IdGenerator.GenerarIdProfesor();
            File.AppendAllText(filePath, id + "," + pro.Nombre + "," + pro.Password + Environment.NewLine);
            Directory.CreateDirectory(Environment.CurrentDirectory + "\\" + id);
            pro.Id = id;
            return id;
        }
        public static void EliminarProfesor(string id)
        {
            List<Profesor>  profesores = ObtenerListaProfesores();
            foreach (Profesor pro in profesores)
            {
                if (id.Equals(pro.Id))
                {
                    //Antes de remover al estudiante de la lista ponlo en el archivo de estudiantes borrados.
                    string filePath = Environment.CurrentDirectory + "\\Profesores_temp.csv";
                    File.AppendAllText(filePath, id + "," + pro.Nombre + "," + pro.Password + Environment.NewLine);

                    profesores.Remove(pro);
                    break;
                }
            }

            Directory.Delete(Environment.CurrentDirectory + "\\" + id, true);
            ReescribirArchivo();
            foreach (Profesor pro in profesores)
            { 
                AñadirProfesor(pro);
            }
        }
        public static List<Profesor> ObtenerListaProfesores()
        {
            string filePath = Environment.CurrentDirectory + "\\Profesores.csv";
            List<Profesor> profesores = new List<Profesor>();

            if (File.Exists(filePath))
            {
                string[] lineas = File.ReadAllLines(filePath);
                string[] datos;

                for (int i = 1; i < lineas.Length; i++)
                {
                    datos = lineas[i].Split(',');
                    profesores.Add(new Profesor(datos[0], datos[1], datos[2]));
                }
            }

            return profesores;
        }
        public static bool VerificarProfesorExiste(string id, string password)
        {
            bool profesorExiste = false;

            foreach (Profesor pro in ObtenerListaProfesores())
            {
                if (pro.Id.Equals(id))
                    if (pro.Password.Equals(password))
                    {
                        profesorExiste = true;
                        break;
                    }
            }
            return profesorExiste;
        }
        public static bool VerificarIdExiste(string id)
        {
            bool idExiste = false;

            foreach (Profesor pro in ObtenerListaProfesores())
            {
                if (pro.Id.Equals(id))
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

            foreach (Profesor pro in ObtenerListaProfesores())
            {
                if (pro.Password.Equals(password))
                {
                    passwordExiste = true;
                    break;
                }
            }

            return passwordExiste;
        }
    }
}
