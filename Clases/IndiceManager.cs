using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class IndiceManager
    {
        public static string TransformarEnLetra(short nota)
        {
            string letra;

            if (nota >= 90)
                letra = "A";
            else if (nota >= 85)
                letra = "B+";
            else if (nota >= 80)
                letra = "B";
            else if (nota >= 75)
                letra = "C+";
            else if (nota >= 70)
                letra = "C";
            else if (nota >= 60)
                letra = "D";
            else
                letra = "F";

            return letra;
        }
        public static decimal TransformarEnValor(short nota)
        {
            decimal valor;
            if (nota >= 90 && nota < 101 )
                valor = 4;
            else if (nota >= 85 && nota < 90)
                valor = 3.5M;
            else if (nota >= 80 && nota < 85)
                valor = 3;
            else if (nota >= 75 && nota < 80)
                valor = 2.5M;
            else if (nota >= 70 && nota < 75)
                valor = 2;
            else if (nota >= 60)
                valor = 1;
            else
                valor = 0;

            return valor;
        }
        public static decimal TransformarEnPuntosHonor(decimal valor, short creditos)
        {
            return valor * creditos;
        }
        public static decimal ObtenerIndice(decimal puntos, short creditos)
        {
            return puntos / creditos;
        }
        public static string Honor(decimal indice)
        {
            string honor;

            if (indice >= 3.8m)
                honor = "Summa Cum Laude";
            else if (indice >= 3.5m)
                honor = "Magna Cum Laude";
            else if (indice >= 3.2m)
                honor = "Cum Laude";
            else
                honor = "Sin honor";

            return honor;
        }
        public static decimal ObtenerIndiceAcumulado(string id)
        {
            List<decimal> indices = new List<decimal>();
            decimal valor, totalPuntos = 0;
            short totalCreditos = 0;

            List<Trimestre> trimestres = RegistroManager.ObtenerTodosRegistros(id);

            foreach (Trimestre tri in trimestres)
            {
                foreach (Registro reg in tri.Registros)
                {
                    valor = TransformarEnValor(reg.grade);
                    totalPuntos += TransformarEnPuntosHonor(valor, Int16.Parse(reg.credValue));
                    totalCreditos += Int16.Parse(reg.credValue);
                }
                indices.Add(ObtenerIndice(totalPuntos, totalCreditos));
            }
            return indices.Average(); 
        }
        public static decimal ObtenerIndiceTrimestre(string id, int trimestre)
        {
            decimal valor, totalPuntos = 0;
            short totalCreditos = 0;

            List<Registro> registros = RegistroManager.ObtenerRegistrosTrimestre(id, trimestre);

            foreach (Registro reg in registros)
            {
                valor = TransformarEnValor(reg.grade);
                totalPuntos += TransformarEnPuntosHonor(valor, Int16.Parse(reg.credValue));
                totalCreditos += Int16.Parse(reg.credValue);
            }

            return ObtenerIndice(totalPuntos, totalCreditos);
        }
    }
}
