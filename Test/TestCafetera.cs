using ProyectoTDD.Maquina;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test
{
    public class TestCafetera
    {
        [Fact]
        public void deberiaDevolverVerdaderoSiExisteCafe()
        {
            var cafetera = new Cafetera(10);

            var resultado = cafetera.hasCafe(5);

            Assert.Equal(true, resultado);
        }

        [Fact]
        public void deberiaDevolverFalsoSiNoExisteCafe()
        {
            var cafetera = new Cafetera(10);

            var resultado = cafetera.hasCafe(11);

            Assert.Equal(false, resultado);
        }

        [Fact]
        public void deberiaRestarcafeAlaCafetera()
        {
            var cafetera = new Cafetera(10);

            cafetera.giveCafe(7);

            Assert.Equal(3,cafetera.getCantidadDeCafe());
        }
    }
}
