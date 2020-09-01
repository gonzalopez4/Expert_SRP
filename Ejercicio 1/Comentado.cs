

/* 
   Kiosco tiene dos responsabilidades, verificar si se puede comprar y hacer el cambio de moneda.
   Kiosco no cumple con el patron SRP debido a que las responsabilidades asignadas no 
   estan relacionadas con solo una funcionalidad sino que estan todas relacionadas,
   Por ejemplo el dinero podria cambiar a dolares y ya afectaria. Por lo cual habria que
   independizar estas responsabilidades a la clase correspondiente.

   Alfajor si cumple SRP, alfajor no tiene mas una razon para cambiar.

   Kiosco no cumple el patron Expert debido a que no se le otorga la informacion al experto 
   en la informacion.

   Alfajor si cumple con el patron Expert. 
   
   

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
