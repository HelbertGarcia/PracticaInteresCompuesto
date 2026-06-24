using System.Globalization;

namespace PracticaInteresCompuesto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Forzar el uso del punto '.' como separador decimal estándar
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Iniciar la interfaz de usuario segregada
            MenuManager.Iniciar();
        }
    }
}