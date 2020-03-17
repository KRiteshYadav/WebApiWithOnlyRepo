using LibraryServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayServices.Data.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();

        Book GetBook(int id);
    }
}
