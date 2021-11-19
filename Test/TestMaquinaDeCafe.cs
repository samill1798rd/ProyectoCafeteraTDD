using ProyectoTDD.Maquina;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test
{
    public class TestMaquinaDeCafe
    {
        public Cafetera cafetera;
        public Vaso vasosPequenos;
        public Vaso vasosMediano;
        public Vaso vasosGrande;
        public Azucarero azucarero;
        public MaquinaDeCafe maquinaDeCafe;
        public TestMaquinaDeCafe()
        {
            cafetera = new Cafetera(50);
            vasosPequenos = new Vaso(5,10);
            vasosMediano = new Vaso(5,20);
            vasosGrande = new Vaso(5,30);
            azucarero = new Azucarero(20);

            maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.setVasosPequeno(vasosPequenos);
            maquinaDeCafe.setVasosMediano(vasosMediano);
            maquinaDeCafe.setVasosGrande(vasosGrande);
            maquinaDeCafe.setAzucarero(azucarero);
        }

        [Fact]
        public void deberiaDevolverUnVasoPequeno()
        {
            var vaso = maquinaDeCafe.getTipoVaso("pequeno");

            Assert.Equal(maquinaDeCafe.vasosPequenos, vaso);
        }

        [Fact]
        public void deberiaDevolverUnVasoMediano()
        {
            var vaso = maquinaDeCafe.getTipoVaso("mediano");

            Assert.Equal(maquinaDeCafe.vasosMedianos, vaso);
        }

        [Fact]
        public void deberiaDevolverUnVasoGrande()
        {
            var vaso = maquinaDeCafe.getTipoVaso("grande");

            Assert.Equal(maquinaDeCafe.vasosGrandes, vaso);
        }

        [Fact]
        public void deberiaDevolverNoHayVasos()
        {
            var vaso = maquinaDeCafe.getTipoVaso("pequeno");

            var result = maquinaDeCafe.getVasoDeCafe(vaso, 10, 2);

            Assert.Equal("no hay vasos",result);
        }

        [Fact]
        public void deberiaDevolverNoHayCafe()
        {
            cafetera = new Cafetera(5);
            maquinaDeCafe.setCafetera(cafetera);

            var vaso = maquinaDeCafe.getTipoVaso("pequeno");

            var result = maquinaDeCafe.getVasoDeCafe(vaso, 1, 2);

            Assert.Equal("no hay cafe", result);
        }

        [Fact]
        public void deberiaDevolverNoHayAzucar()
        {
            cafetera = new Cafetera(10);
            maquinaDeCafe.setCafetera(cafetera);
            azucarero = new Azucarero(2);
            maquinaDeCafe.setAzucarero(azucarero);

            var vaso = maquinaDeCafe.getTipoVaso("pequeno");

            var result = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            Assert.Equal("no hay azucar", result);
        }

        [Fact]
        public void deberiaRestarCafe()
        {
            cafetera = new Cafetera(50);
            maquinaDeCafe.setCafetera(cafetera);
            azucarero = new Azucarero(20);
            maquinaDeCafe.setAzucarero(azucarero);


            var vaso = maquinaDeCafe.getTipoVaso("pequeno");

            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            var result = maquinaDeCafe.getCafetera().getCantidadDeCafe();

            Assert.Equal(40, result);
        }

        [Fact]
        public void deberiaRestarVaso()
        {
            cafetera = new Cafetera(50);
            maquinaDeCafe.setCafetera(cafetera);
            azucarero = new Azucarero(20);
            maquinaDeCafe.setAzucarero(azucarero);


            var vaso = maquinaDeCafe.getTipoVaso("pequeno");

            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            var result = maquinaDeCafe.getVasosPequeno().getCantidadVasos();

            Assert.Equal(4, result);
        }

        [Fact]
        public void deberiaRestarAzucar()
        {
            cafetera = new Cafetera(50);
            maquinaDeCafe.setCafetera(cafetera);
            azucarero = new Azucarero(20);
            maquinaDeCafe.setAzucarero(azucarero);


            var vaso = maquinaDeCafe.getTipoVaso("pequeno");

            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

            var result = maquinaDeCafe.getAzucarero().getCantidadDeAzucar();

            Assert.Equal(17, result);
        }

        [Fact]
        public void deberiaDevolverFelicitaciones()
        {
            cafetera = new Cafetera(50);
            maquinaDeCafe.setCafetera(cafetera);
            azucarero = new Azucarero(20);
            maquinaDeCafe.setAzucarero(azucarero);

            var vaso = maquinaDeCafe.getTipoVaso("pequeno");

            var result = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);

  
            Assert.Equal("Felicitaciones",result);
        }
    }
}
