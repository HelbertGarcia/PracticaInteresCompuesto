using System.Globalization;

namespace PracticaInteresCompuesto
{
    public static class MenuManager
    {
        /// <summary>
        /// Controla el ciclo de vida de la pantalla de captura y resultados del interés compuesto.
        /// </summary>
        public static void Iniciar()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("   SISTEMA DE CAPITALIZACIÓN RECURSIVA v1.0       ");
            Console.WriteLine("==================================================\n");

            // 1. Lectura de variables con soporte decimal y enteros no negativos
            decimal m = LeerDecimal("Ingrese el capital inicial depositado (m): ");
            decimal X = LeerDecimal("Ingrese la tasa de interés anual en porcentaje % (X): ");
            int n = LeerEntero("Ingrese el tiempo de la inversión en años (n): ");

            // 2. Procesamiento del negocio invocando el componente recursivo externo
            decimal montoFinal = CalculoInteresCompuesto.CalcularInteresCompuesto(m, X, n);

            // 3. Despliegue de salida en pantalla
            MostrarResultados(m, X, n, montoFinal);

            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }

        /// <summary>
        /// Imprime los datos del procesamiento formateados a dos posiciones decimales.
        /// </summary>
        private static void MostrarResultados(decimal capital, decimal tasa, int anos, decimal total)
        {
            Console.WriteLine("\n==================================================");
            Console.WriteLine("               RESULTADOS DEL CÁLCULO             ");
            Console.WriteLine("==================================================");
            Console.WriteLine($" Capital Inicial (m):       {capital:N2}");
            Console.WriteLine($" Tasa de Interés Anual (X): {tasa:N2}%");
            Console.WriteLine($" Tiempo de Inversión (n):   {anos} años");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($" Monto Total Acumulado (C): {total:N2}");
            Console.WriteLine("==================================================\n");
        }

        /// <summary>
        /// Lee y valida la entrada para asegurar un valor numérico decimal positivo.
        /// </summary>
        private static decimal LeerDecimal(string mensaje)
        {
            decimal valor;
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine() ?? "";
                // Criterio de Aceptación 3: Soporta valores decimales para capital y tasa
                if (decimal.TryParse(entrada, NumberStyles.Any, CultureInfo.InvariantCulture, out valor) && valor >= 0)
                {
                    return valor;
                }
                Console.WriteLine("[Error] Entrada inválida. Ingrese un número decimal positivo.");
            }
        }

        /// <summary>
        /// Lee y valida la entrada para asegurar un año válido no negativo.
        /// </summary>
        private static int LeerEntero(string mensaje)
        {
            int valor;
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine() ?? "";
                // Criterio de Aceptación 1: Permite n = 0 de forma segura sin romper la ejecución
                if (int.TryParse(entrada, out valor) && valor >= 0)
                {
                    return valor;
                }
                Console.WriteLine("[Error] Entrada inválida. Ingrese un número entero mayor o igual a 0.");
            }
        }
    }
}