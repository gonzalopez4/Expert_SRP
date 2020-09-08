using System;

namespace Expert_SRP
{
    /*
    SRP:
    Alfajor si cumple SRP, alfajor no tiene mas una razon o motivo para cambiar. 
    
    EXPERT:
    Alfajor si cumple con el patron Expert. Es el experto en la informacion de la responsabilidad que tiene.
    
    Observacion:
    El alfajor deberia calcular su precio y se deberia crear una nueva clase que calcule el cambio de moneda.
    */
    
    public class Alfajor 
   
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}
