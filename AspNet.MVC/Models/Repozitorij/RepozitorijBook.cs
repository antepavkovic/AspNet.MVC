using AspNet.MVC.Models;
using System.Xml.Linq;

namespace AspNet.MVC.Models.Repozitorij
{
    public class RepozitorijBook
    {

        private static List<Book> books;

        public RepozitorijBook()
        {
            if (books == null)
            {

                books = new List<Book>();
                SimulirajBazu();
            }
        }

        private void SimulirajBazu()
        {
            Author author1 = new Author { Id = 1, ImePrezime = "Karlo Grgurević", Country = "Croatia" };
            Author author2 = new Author { Id = 2, ImePrezime = "Goran Ivanišević", Country = "Croatia" };
            Author author3 = new Author { Id = 3, ImePrezime = "Ivan Mavrovic", Country = "Croatia" };

            Book book1 = new Book() { Name = "To Kill a Mockingbird", NumberOfPages = 192 };
            Book book2 = new Book() { Name = "Fahrenheit 451", NumberOfPages = 324 };
            Book book3 = new Book() { Name = "The Diary of a Young Girl", NumberOfPages = 435 };
            Book book4 = new Book() { Name = "1984", NumberOfPages = 543 };
            Book book5 = new Book() { Name = "Romeo and Juliet", NumberOfPages = 322 };
            book1.Authors.Add(author1);
            book2.Authors.Add(author2);
            book3.Authors.Add(author3);
            book4.Authors.Add(author1);
            book5.Authors.Add(author2);
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);
        }
        public List<Book> DohvatiSveKnjige()
        {
            return books;

        }
    }
}
