using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoTDD.Maquina
{
    public class MaquinaDeCafe
    {
        private Cafetera Cafe { get; set; }
        public Vaso vasosPequenos { get; set; }
        public Vaso vasosMedianos { get; set; }
        public Vaso vasosGrandes { get; set; }
        private Azucarero azucar { get; set; }

        public Vaso getTipoVaso(string tipoVaso)
        {
            Vaso vasoNew = null;
            switch (tipoVaso)
            {
                case "pequeno":
                    vasoNew = vasosPequenos;
                    break;
                case "mediano":
                    vasoNew = vasosMedianos;
                    break;
                case "grande":
                    vasoNew = vasosGrandes;
                    break;
            }

            return vasoNew;
        }

        public string getVasoDeCafe(Vaso tipoDeVaso, int cantidadDeVaso, int cantidadDeAzucar)
        {
            if (!tipoDeVaso.hasVasos(cantidadDeVaso))
                return "no hay vasos";
            if (!this.Cafe.hasCafe(tipoDeVaso.getContenido()))
                return "no hay cafe";
            if (!this.azucar.hasAzucar(cantidadDeAzucar))
                return "no hay azucar";
       
            if (this.vasosPequenos.getContenido() == tipoDeVaso.getContenido())
                this.vasosPequenos.giveVasos(cantidadDeVaso);
            else if (this.vasosMedianos.getContenido() == tipoDeVaso.getContenido())
                this.vasosMedianos.giveVasos(cantidadDeVaso);
            else if (this.vasosGrandes.getContenido() == tipoDeVaso.getContenido())
                this.vasosGrandes.giveVasos(cantidadDeVaso);
            else return "Error al Obtener Vaso";

            this.azucar.giveAzucar(cantidadDeAzucar);
            this.Cafe.giveCafe(tipoDeVaso.getContenido());
            return "Felicitaciones";
        }

        public void setVasosPequeno(Vaso VasosPequeno)
        {
            vasosPequenos = VasosPequeno;
        }
        public void setVasosMediano(Vaso VasosMediano)
        {
            vasosMedianos = VasosMediano;
        }

        public void setVasosGrande(Vaso VasosGrande)
        {
            vasosGrandes = VasosGrande;
        }

        public void setAzucarero(Azucarero azucarero)
        {
            azucar = azucarero;
        }

        public void setCafetera(Cafetera cafetera)
        {
            Cafe = cafetera;
        }

        public Cafetera getCafetera()
        {
            return Cafe;
        }

        public Vaso getVasosPequeno()
        {
            return vasosPequenos;
        }

        public Azucarero getAzucarero()
        {
            return azucar;
        }




    }
}
