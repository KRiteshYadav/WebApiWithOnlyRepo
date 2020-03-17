using LibrarayServices.Data.Interfaces;
using LibrarayServices.Data.Repositories;
using LibraryServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LibraryServices.Controllers
{
    public class BooksController : ApiController
    {
        //private IBookRepository books =new BookRepository();
        private IBookRepository books;

        public BooksController(IBookRepository _books)
        {
            this.books = _books;
        }

        // GET api/Books
        public IEnumerable<Book> Get()
        {
            return books.GetAllBooks();
        }

        // GET api/Books/5
        public IHttpActionResult Get(int id)
        {
            var book = books.GetBook(id);
            if (book == null)
                return NotFound();

            return Ok(book);
        }
    }
}
