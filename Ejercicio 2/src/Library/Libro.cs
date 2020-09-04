using System;

namespace SRP
{
    /*
    La clase libro no cumple con SRP pues tiene dos razones de cambio, la ubicacion y la informacion.
    El libro no tiene por qué saber donde esta colocado en la biblioteca.
    Se deberia crear una nueva clase encargada de tener la responabilidad de almacenar el libro 
    en un estante y otra nueva que almacene los estantes
    */
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
