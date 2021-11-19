using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoTDD.Maquina
{
    public class Azucarero
    {
        private int cantidadDeAzucar;

        public Azucarero(int cantidad)
        {
            setCantidadDeAzucar(cantidad);
        }
        public void setCantidadDeAzucar(int cantidadAzucar)
        {
            cantidadDeAzucar = cantidadAzucar;
        }

        public int getCantidadDeAzucar()
        {
            return cantidadDeAzucar;
        }

        public bool hasAzucar(int cantidadAzucar)
        {
            return this.cantidadDeAzucar >= cantidadAzucar ? true : false;
        }

        public void giveAzucar(int cantidadAzucar)
        {
            this.cantidadDeAzucar = getCantidadDeAzucar() - cantidadAzucar;
        }

    }
}
