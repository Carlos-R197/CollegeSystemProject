using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clases;

namespace UnitTestProject
{
    [TestClass]
    public class RegisterClassTest
    {
        [TestMethod]
        public void RegisterClass()
        {
            var professor = new Profesor("Pedro Guzman", "5kpo9fU");
            var classSection = new Seccion(professor, "Calculo Diferencial");
            classSection.AñadirCalificacion(new EstudianteSeccion("Sebastian Soto", 89));
            classSection.AñadirCalificacion(new EstudianteSeccion("Carlos Roque", 82));
            var savedSection = SeccionManager.ObtenerPrimeraSeccion("Calculo Diferencial", professor);

            bool areSectionsEqual = false;
            if (classSection.Materia == savedSection.Materia && classSection.NumeroSeccion == savedSection.NumeroSeccion &&
                classSection.Profesor.Id == savedSection.Profesor.Id)
                areSectionsEqual = true;

            Assert.IsTrue(areSectionsEqual);
        }
    }
}
