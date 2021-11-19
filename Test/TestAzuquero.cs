using ProyectoTDD.Maquina;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test
{
    public class TestAzuquero
    {
        public Azucarero azucarero;
        public TestAzuquero()
        {
            azucarero = new Azucarero(10);
        }
        [Fact]
        public void deberiaDevolverVerdaderoSiHaySuficienteAzucarEnElAzuquero()
        {

            var resultado = azucarero.hasAzucar(5);

            Assert.Equal(true, resultado);


            resultado = azucarero.hasAzucar(10);

            Assert.Equal(true, resultado);
        }

        [Fact]
        public void deberiaDevolverFalsoPorqueNoHaySuficienteAzucarEnElAzuquero()
        {
            var resultado = azucarero.hasAzucar(15);

            Assert.Equal(false, resultado);
        }

        [Fact]
        public void deberiaRestarAzucarAlAzuquero()
        {
            azucarero.giveAzucar(5);

            Assert.Equal(5, azucarero.getCantidadDeAzucar());

            azucarero.giveAzucar(2);

            Assert.Equal(3, azucarero.getCantidadDeAzucar());
        }
    }
}
