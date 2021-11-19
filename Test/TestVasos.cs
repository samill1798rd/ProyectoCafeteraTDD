using ProyectoTDD.Maquina;
using System;
using Xunit;

namespace Test
{
    public class TestVasos
    {
        [Fact]
        public void deberiaDevolverVerdaderoSiExistenVasos()
        {
            var vasosPequenos = new Vaso(2, 10);

            var resultado = vasosPequenos.hasVasos(1);

            Assert.Equal(true, resultado);
        }

        [Fact]
        public void deberiaDevolverFalsoSiNoExistenVasos()
        {
            var vasosPequenos = new Vaso(1, 2);

            var resultado = vasosPequenos.hasVasos(2);

            Assert.Equal(false, resultado);
        }

        [Fact]
        public void deberiaRestarCantidadDEVasos()
        {
            var vasosPequenos = new Vaso(5, 10);

            vasosPequenos.giveVasos(1);

            Assert.Equal(4,vasosPequenos.getCantidadVasos());
        }

    }
}
