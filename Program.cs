using ArrayInitializingTask.Models;

namespace ArrayInitializingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Beyaz geceler", "Dostoyevski");

            Book book2 = new Book("Patriaxin payizi", "Gabriel");
            Book book3 = new Book("Qumarbaz", "Dostoyevski");

            BookLibrary library = new BookLibrary {Name="Kitablar" };
            
            library.Add(book);
            library.Add(book2);
            library.Add(book3);

            //library.BorrowBook("Beyaz geceler");
            //library.ShowAll();
            //library.ReturnBook("Beyaz geceler");
            //library.ShowAll();
            library.SearchByAuthor("Dostoyevski");






        }
    }
}
