using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using Xunit;

namespace UnitTest
{
    public class IndiceTest
    {
        [Theory]
        [InlineData(80,"B")]
        [InlineData(91, "A")]
        [InlineData(86, "B+")]
        [InlineData(55, "F")]
        [InlineData(73, "C")]
        [InlineData(78, "C+")]
        [InlineData(61, "D")]
        public void IndiceManager_TransformacionEnLetraCorrecta(short valor, string expected)
        {      
            string actual = IndiceManager.TransformarEnLetra(valor);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,95)]
        [InlineData(3.5, 86)]
        [InlineData(3,80)]
        [InlineData(2.5, 75)]
        [InlineData(2, 71)]
        [InlineData(1, 65)]
        [InlineData(0, 55)]

        public void IndiceManager_TransformarEnValorCorrectamente(decimal expected, short nota)
        {
            decimal actual = IndiceManager.TransformarEnValor(nota);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(16, 4,4)]
        [InlineData(10, 5, 2)]
        [InlineData(10.5, 3, 3.5)]
        [InlineData(5, 2, 2.5)]
        public void IndiceManager_TransformarEnPuntosHonor(decimal expected, short creditos, decimal valor)
        {
            decimal actual = IndiceManager.TransformarEnPuntosHonor(valor, creditos);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("Summa Cum Laude", 4)]
        [InlineData("Magna Cum Laude", 3.55)]
        [InlineData("Cum Laude", 3.3)]
        [InlineData("Sin honor", 2.5)]

        public void IndiceManager_ObtenerHonor(string expected, decimal indice)
        {
            string actual = IndiceManager.Honor(indice);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData (3,"1-2019-0002", 1)]
        [InlineData(3.25, "1-2019-0001", 1)]
        public void IndiceManager_IndiceTrimestralCorrecto(decimal expected,string id, int trimestre)
        {
            decimal actual = IndiceManager.ObtenerIndiceTrimestre( id, trimestre);
            Assert.Equal(expected, actual);
        }
       
    }
}
