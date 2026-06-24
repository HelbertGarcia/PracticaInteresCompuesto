using System;

namespace PracticaInteresCompuesto
{
    public static class CalculoInteresCompuesto
    {
        /// <summary>
        /// Calcula el monto final acumulado después de n años aplicando la fórmula de interés compuesto de manera recursiva.
        /// </summary>
        /// <param name="capitalInicial"></param>
        /// <param name="tasaInteresAnual"></param>
        /// <param name="tiempoEnAnios"></param>
        /// <returns></returns>
        public static decimal CalcularInteresCompuesto(decimal capitalInicial, decimal tasaInteresAnual, int tiempoEnAnios)
        {
            decimal i = tasaInteresAnual / 100;
            return EjecutarCapitalizacionRecursiva(capitalInicial, i, tiempoEnAnios);
        }

        /// <summary>
        /// Realiza la capitalización recursiva del capital inicial aplicando la tasa de interés durante n años.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="i"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private static decimal EjecutarCapitalizacionRecursiva(decimal m, decimal i, int n)
        {
            if (n <= 0)
            {
                return m;
            }

            return EjecutarCapitalizacionRecursiva(m, i, n - 1) * (1 + i);
        }
    }
}