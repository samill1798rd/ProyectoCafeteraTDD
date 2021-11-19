using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoTDD.Maquina
{
    public class Vaso
    {
        private int cantidadVasos = 0;
        private int contenido = 0;

        public Vaso(int cantidadVasos,int contenido)
        {
            setCantidadVasos(cantidadVasos);
            setContenido(contenido);
        }

        public void setCantidadVasos(int cantidad)
        {
            cantidadVasos = cantidad;
        }

        public int getCantidadVasos()
        {
            return cantidadVasos;
        }

        public void setContenido(int contenido)
        {
            this.contenido = contenido;
        }

        public int getContenido()
        {
            return contenido;
        }

        public bool hasVasos(int cantidadVasos)
        {
            return this.cantidadVasos >= cantidadVasos ? true : false;
        }

        public void giveVasos(int cantidadVasosNum)
        {
            cantidadVasos = getCantidadVasos()-cantidadVasosNum;
        }
    }
}
