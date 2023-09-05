using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            ShelveBook Position1 = new ShelveBook(book1,"A","7");
            ShelveBook Position2 = new ShelveBook(book2 ,"B","3");
            // ShelveBook Position1 = new ShelveBook();
            // ShelveBook Position2 = new ShelveBook();

            // Position1.PositionShelveBook(book1,"A","7");
            // Position2.PositionShelveBook(book2 ,"B","3");
            Console.WriteLine(Position1.LibrarySector);
            Console.WriteLine(Position1.LibraryShelve);




        }
    }
}