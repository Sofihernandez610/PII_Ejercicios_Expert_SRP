using System;

namespace SRP
{
    public class Book
    {
        //La clase libro no cumple con el principio SRP ya que tiene dos responsabilidades, la de conocer los atributos de libro y tambien colocar los libros en el estante conociendo el sector y el estante
        //Para que cumple con el principio decidi crear una nueva clase llamada ShelveBook que sera la encargada de colocar el libro en el estante y sector adecuado

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}
