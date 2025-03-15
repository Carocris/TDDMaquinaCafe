namespace SistemaCafe
{
    public class ExpendedorCafe
    {
        private static readonly HashSet<string> TiposVasos = new() { "Pequeño", "Mediano", "Grande" };

        /// <summary>
        /// Permite elegir un vaso si está disponible.
        /// </summary>
        public string ElegirVaso(string tipo, bool disponibles)
        {
            if (!TiposVasos.Contains(tipo))
                return "Error: Tipo de vaso inválido";

            if (!disponibles)
                return "Error: No hay vasos en stock";

            return $"Vaso {tipo} seleccionado correctamente";
        }

        /// <summary>
        /// Permite ajustar la cantidad de azúcar si hay suficiente.
        /// </summary>
        public string ConfigurarAzucar(int cantidad, bool disponible)
        {
            if (cantidad < 0 || cantidad > 5)
                return "Error: Cantidad de azúcar no permitida";

            if (!disponible)
                return "Error: Azúcar agotada";

            return $"Se han añadido {cantidad} cucharadas de azúcar";
        }

        /// <summary>
        /// Prepara café si hay disponibilidad y se seleccionó un vaso válido.
        /// </summary>
        public string DispensarCafe(string tipo, int azucar, bool hayStock)
        {
            if (!TiposVasos.Contains(tipo))
                return "Error: Seleccione un vaso antes de preparar el café";

            if (!hayStock)
                return "Error: No hay café disponible";

            return $"Sirviendo café en vaso {tipo} con {azucar} cucharadas de azúcar";
        }
    }
}
