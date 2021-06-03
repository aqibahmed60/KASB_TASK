using Bookstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Data.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAllBook();

        Book GetBook(int id);
    }
}
