using SistemaCafe;
using Xunit;

namespace SistemaCafe.Tests
{
    public class ExpendedorCafePruebas
    {
        private readonly ExpendedorCafe _expendedor = new();

        [Fact]
        public void Debe_Seleccionar_Vaso_Correcto()
        {
            var resultado = _expendedor.ElegirVaso("Mediano", true);
            Assert.Equal("Vaso Mediano seleccionado correctamente", resultado);
        }

        [Fact]
        public void No_Debe_Aceptar_Vaso_No_Valido()
        {
            var resultado = _expendedor.ElegirVaso("ExtraGrande", true);
            Assert.Equal("Error: Tipo de vaso inválido", resultado);
        }

        [Fact]
        public void No_Debe_Seleccionar_Vaso_Si_No_Hay()
        {
            var resultado = _expendedor.ElegirVaso("Mediano", false);
            Assert.Equal("Error: No hay vasos en stock", resultado);
        }

        [Fact]
        public void Debe_Agregar_Azucar_En_Rango()
        {
            var resultado = _expendedor.ConfigurarAzucar(2, true);
            Assert.Equal("Se han añadido 2 cucharadas de azúcar", resultado);
        }

        [Fact]
        public void No_Debe_Aceptar_Azucar_Fuera_De_Rango()
        {
            var resultado = _expendedor.ConfigurarAzucar(-1, true);
            Assert.Equal("Error: Cantidad de azúcar no permitida", resultado);
        }

        [Fact]
        public void No_Debe_Agregar_Azucar_Si_No_Hay()
        {
            var resultado = _expendedor.ConfigurarAzucar(2, false);
            Assert.Equal("Error: Azúcar agotada", resultado);
        }

        [Fact]
        public void No_Debe_Servir_Cafe_Si_No_Hay()
        {
            var resultado = _expendedor.DispensarCafe("Pequeño", 1, false);
            Assert.Equal("Error: No hay café disponible", resultado);
        }

        [Fact]
        public void Debe_Servir_Cafe_Correctamente()
        {
            var resultado = _expendedor.DispensarCafe("Grande", 3, true);
            Assert.Equal("Sirviendo café en vaso Grande con 3 cucharadas de azúcar", resultado);
        }

        [Fact]
        public void No_Debe_Servir_Cafe_Sin_Seleccionar_Vaso()
        {
            var resultado = _expendedor.DispensarCafe("ExtraGrande", 2, true);
            Assert.Equal("Error: Seleccione un vaso antes de preparar el café", resultado);
        }
    }
}