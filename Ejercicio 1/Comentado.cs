

/* Kiosco no cumple con el patron SRP debido a que las responsabilidades asignadas no 
   estan relacionadas con solo una funcionalidad sino que estan todas relacionadas,
   El dinero podria cambiar por ejemplo a dolares y ya afectaria.

   Alfajor si cumple SRP, tiene solo una razon para cambiar.

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
