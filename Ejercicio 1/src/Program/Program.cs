

/* 
   • Kiosco tiene dos responsabilidades (motivos de cambio), verificar si se puede comprar y hacer el cambio de moneda.
   Kiosco no cumple con el patron SRP debido a que las responsabilidades asignadas no 
   estan relacionadas con solo una funcionalidad sino que estan todas relacionadas,
   Por ejemplo el dinero podria cambiar a dolares y ya afectaria. Por lo cual habria que
   independizar estas responsabilidades a la clase correspondiente.
   
   
   • Alfajor si cumple SRP, alfajor no tiene mas una razon para cambiar. 
   
   
   • Kiosco no cumple el patron Expert debido a que no se le otorga la informacion al experto 
   en la informacion.
   El tipo de cambio deberia ser una clase a parte para no generar conflicto con Kiosco debido 
   a que no es el experto en esta informacion.
   
   
   • Alfajor si cumple con el patron Expert. Es el experto en la informacion de la responsabilidad que tiene.
     Alfajor deberia ser el responsable de hacer el calculo de precios o delegarle esta responsabilidad a otra clase que lo haga.
   
   Solucion:
   El alfajor deberia calcular su precio y se deberia crear una nueva clase que calcule el cambio de moneda.
   

*/


using System;

namespace Expert_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Alfajor a = new Alfajor(10, 8.5);
            Kiosco k = new Kiosco();
            if (k.PuedeComprar(a, 15, "$"))
            {
                Console.WriteLine("Felicitaciones! Tiene suficiente dinero para comprar un alfajor :)");
            }
            else
            {
                Console.WriteLine("Mejor consiga un trabajo :(");
            }
        }
    }
}
