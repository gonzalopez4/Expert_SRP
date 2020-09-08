using System;

namespace Expert_SRP
{
    //Se agrego la clase Convertir que sea la responsable de realizar el cambio de moneda
    //Con el objetivo de quitarle esta responsabilidad a Kiosko.
    public class Convertir 
    {
        public Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
        public Double dinero {get;set;}
        public Double moneda {get; set;}
    }
}
