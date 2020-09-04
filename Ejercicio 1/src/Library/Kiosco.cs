using System;

namespace Expert_SRP
{
    /*
    SRP: 
    Kiosco no cumple con el patron SRP debido a que tiene dos responsabilidades (o dos razones de cambio) asociadas a esta misma clase, 
    verificar si se puede comprar y hacer el cambio de moneda. Las responsabilidades asignadas no estan relacionadas con solo una funcionalidad.
    Por ejemplo el tipo de cambio podria cambiar a dolares y esto se vería afectado. Por lo que habria que independizar el tipo de cambio a una nueva clase o alfajor.

    EXPERT:
    Kiosco es el responsable de calcular el costo del alfajor, y estos datos se los pedia a Alfajor por lo cual no cumple el patron Expert
    debido a que no se le otorga la informacion al experto en la informacion, en este caso Alfajor era el experto en esa clase.
    
    */
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Convertir k = new Convertir();
            Double pesos = k.ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
    }
}
