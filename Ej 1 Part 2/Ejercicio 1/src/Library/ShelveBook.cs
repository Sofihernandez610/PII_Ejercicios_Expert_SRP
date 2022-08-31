using System;
using System.Collections.Generic;

namespace SRP
{
    public class ShelveBook
    {
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        List <Book> Libros = new List < Book > (); //creo una lista donde se van a gusradar los libros
        
        public void AddBook (Book book)   //metodo para agregar libro a la lista
        {
            this.Libros.Add (book);
        }
         public void RemoveBook (Book book)    //metodo para eliminar un libro de la lista
        {
            this.Libros.Remove(book);
        }


         public ShelveBook(String sector, String shelve)    //constructor
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
            
            
        }
        public override string ToString ()     //creo un metodo para generar el texto a imprimir
        {
            string r = String.Join(", ", this.Libros);
             return $"El libro {r} esta ubicado en el sector {this.LibrarySector} y en el estante {this.LibraryShelve}";
        }
        
       
     }
}