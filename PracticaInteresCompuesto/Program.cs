using System;
using System.Globalization;

namespace PracticaInteresCompuesto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("==================================================");
            Console.WriteLine("   SISTEMA DE CAPITALIZACIÓN RECURSIVA v1.0       ");
            Console.WriteLine("==================================================\n");

            decimal m = LeerDecimal("Ingrese el capital inicial depositado (m): ");
            decimal X = LeerDecimal("Ingrese la tasa de interés anual en porcentaje % (X): ");
            int n = LeerEntero("Ingrese el tiempo de la inversión en años (n): ");

            decimal montoFinal = CalculoInteresCompuesto.CalcularInteresCompuesto(m, X, n);

            Console.WriteLine("\n==================================================");
            Console.WriteLine("               RESULTADOS DEL CÁLCULO             ");
            Console.WriteLine("==================================================");
            Console.WriteLine($" Capital Inicial (m):       {m:N2}");
            Console.WriteLine($" Tasa de Interés Anual (X): {X:N2}%");
            Console.WriteLine($" Tiempo de Inversión (n):   {n} años");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($" Monto Total Acumulado (C): {montoFinal:N2}");
            Console.WriteLine("==================================================\n");

            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }

        private static decimal LeerDecimal(string mensaje)
        {
            decimal valor;
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine() ?? "";
                if (decimal.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out valor) && valor >= 0)
                {
                    return valor;
                }
                Console.WriteLine("[Error] Entrada inválida. Ingrese un número decimal positivo (ej: 1500.50 o 5.5).");
            }
        }

        private static int LeerEntero(string mensaje)
        {
            int valor;
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine() ?? "";
                if (int.TryParse(entrada, out valor) && valor >= 0)
                {
                    return valor;
                }
                Console.WriteLine("[Error] Entrada inválida. Ingrese un número entero mayor o igual a 0.");
            }
        }
    }
}