using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        // public string LibrarySector { get ; set; }
        // public string LibraryShelve { get ; set; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        // public void ShelveBook(String sector, String shelve)
        // {
        //     this.LibrarySector = sector;
        //     this.LibraryShelve = shelve;
        // }
    


    /*
    Habria que modificar el código para que cumpla completamente con el SRP.
    Se debería crear una nueva clase "ShelveBook" o algo parecido y en esa
    clase asignarle la responsabilidad de ordenar los libros en distintas 
    "Shelves". Asimismo, habría que quitar la parte comentada previamente
    ya que la nueva clase cumplira con esa tarea.
    */
    }
    public class ShelveBook
    {
    
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        public Book Book{ get; set;}


        public ShelveBook(Book book, string sector, string shelve){
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
            this.Book = book;
            
        }
    }
}
