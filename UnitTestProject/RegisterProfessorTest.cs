using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clases;

namespace UnitTestProject
{
    [TestClass]
    public class RegisterProfessorTest
    {
        [TestMethod]
        public void RegisterProfessor()
        {
            string password = "5kpo9fU";
            var professor = new Profesor("Pedro Guzmán", password);
            Profesor.CrearArchivo();
            Profesor.AñadirProfesor(professor);
            bool result = Profesor.VerificarProfesorExiste(professor.Id, password);
            Assert.IsTrue(result);
        }
    }
}
