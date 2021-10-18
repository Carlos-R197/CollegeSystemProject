using NUnit.Framework;
using Clases;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string password = "12345678";
            var student = new Estudiante(password, "Sebastian Soto", "Ingenieria de software");
            Estudiante.AñadirEstudiante(student);
            bool result = Estudiante.VerificarEstudianteExiste(student.ID, password);
            Estudiante.EliminarEstudiante(student.ID);
            Assert.IsTrue(result);
        }
    }
}