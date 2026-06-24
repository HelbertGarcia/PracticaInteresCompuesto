using System;

namespace PracticaInteresCompuesto
{
    public static class CalculoInteresCompuesto
    {
        public static decimal CalcularInteresCompuesto(decimal capitalInicial, decimal tasaInteresAnual, int tiempoEnAnios)
        {
            decimal i = tasaInteresAnual / 100;
            return EjecutarCapitalizacionRecursiva(capitalInicial, i, tiempoEnAnios);
        }

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