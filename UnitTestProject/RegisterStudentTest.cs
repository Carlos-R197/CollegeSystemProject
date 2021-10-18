using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clases;

namespace UnitTestProject
{
    [TestClass]
    public class RegisterStudentTest
    {
        [TestMethod]
        public void RegisterTest()
        {
            string password = "12345678";
            var student = new Estudiante(password, "Sebastian Soto", "Ingenieria de software");
            Estudiante.CrearArchivo();
            Estudiante.AñadirEstudiante(student);
            bool result = Estudiante.VerificarEstudianteExiste(student.ID, password);
            Estudiante.EliminarEstudiante(student.ID);
            Assert.IsTrue(result);
        }
    }
}
