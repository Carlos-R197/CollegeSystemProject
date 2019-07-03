using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    class IndiceManager
    {

        private static float TransformarEnValor(short nota)
        {
            float valor;
            if (nota >= 90)
                valor = 4;
            else if (nota >= 85)
                valor = 3.5f;
            else if (nota >= 80)
                valor = 3;
            else if (nota >= 75)
                valor = 2.5f;
            else if (nota >= 70)
                valor = 2;
            else if (nota >= 60)
                valor = 1;
            else
                valor = 0;

            return valor;
        }

        private static float TransformarEnPuntosHonor(float valor, short creditos)
        {
            return valor * creditos;
        }

        public static int SumarPuntosHonor(List<short> puntos)
        {
            int suma = 0;

            foreach (short num in puntos)
            {
                suma += num;
            }

            return suma;
        }

        private static float ObtenerIndice(float puntos, short creditos)
        {
            return puntos / creditos;
        }

        public static string Honor(float indice)
        {
            string honor;

            if (indice >= 3.8f)
                honor = "Summa Cum Laude";
            else if (indice >= 3.5f)
                honor = "Magna Cum Laude";
            else if (indice >= 3.2f)
                honor = "Cum Laude";
            else
                honor = "Sin honor";

            return honor;
        }

        public static float ObtenerIndiceAcumulado(int id)
        {
            List<float> indices = new List<float>();
            float valor, totalPuntos = 0;
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
            return indices.Average(); ;
        }

        public static float ObtenerIndiceTrimestre(int id, int trimestre)
        {
            float valor, totalPuntos = 0;
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
