using LibrarayServices.Data.Interfaces;
using LibraryServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayServices.Data.Repositories
{
    public class BookRepository : IBookRepository
    {

        public List<Book> books = new List<Book>()
        {
            new Book{Id =1 ,Title ="GOT", Author="George R.R Martin",PublicationYear=2010 , CallNumber="SF Martin" },
            new Book{Id =2 ,Title ="Harry", Author="Dumbledore",PublicationYear=2008 , CallNumber="Hogwarts Martin" }

        };

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            return book;

        }
    }
}
