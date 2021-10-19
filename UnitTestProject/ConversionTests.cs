using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clases;

namespace UnitTestProject
{
    [TestClass]
    public class ConversionTests
    {
        [DataTestMethod]
        [DataRow(80, "B")]
        [DataRow(91, "A")]
        [DataRow(86, "B+")]
        [DataRow(55, "F")]
        [DataRow(73, "C")]
        [DataRow(78, "C+")]
        [DataRow(61, "D")]
        public void GradeToLetterTest(int valor, string expected)
        {
            string actual = IndiceManager.TransformarEnLetra(valor);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(4f, (short)95)]
        [DataRow(3.5f, (short)86)]
        [DataRow(3f, (short)80)]
        [DataRow(2.5f, (short)75)]
        [DataRow(2f, (short)71)]
        [DataRow(1f, (short)65)]
        [DataRow(0f, (short)55)]

        public void GradeToPointsTest(float expected, short nota)
        {
            float actual = IndiceManager.TransformarEnValor(nota);
            Assert.AreEqual(expected, actual);
        }


        [DataTestMethod]
        [DataRow(16f, (short)4, 4f)]
        [DataRow(10f, (short)5, 2f)]
        [DataRow(10.5f, (short)3, 3.5f)]
        [DataRow(5f, (short)2, 2.5f)]
        public void HonorPointsConversionTest(float expected, short creditos, float valor)
        {
            float actual = IndiceManager.TransformarEnPuntosHonor(valor, creditos);
            Assert.AreEqual(expected, actual);
        }


        [DataTestMethod]
        [DataRow("Summa Cum Laude", 4f)]
        [DataRow("Magna Cum Laude", 3.55f)]
        [DataRow("Cum Laude", 3.3f)]
        [DataRow("", 2.5f)]

        public void HonorConversionTest(string expected, float indice)
        {
            string actual = IndiceManager.Honor(indice);
            Assert.AreEqual(expected, actual);
        }
    }
}
