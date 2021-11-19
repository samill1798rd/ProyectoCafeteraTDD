using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoTDD.Maquina
{
    public class Cafetera
    {
        private int cantidadCafe;

        public Cafetera(int cantidad)
        {
            setCantidadDeCafe(cantidad);
        }

        public void setCantidadDeCafe(int cantidad)
        {
            cantidadCafe = cantidad;
        }

        public int getCantidadDeCafe()
        {
            return cantidadCafe;
        }

        public bool hasCafe(int cantidadCafe)
        {
            return this.cantidadCafe >= cantidadCafe ? true : false;
        }

        public void giveCafe(int cantidadCafe)
        {
            this.cantidadCafe = getCantidadDeCafe() - cantidadCafe;
        }


    }
}
