using System;

namespace Expert_SRP
{
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