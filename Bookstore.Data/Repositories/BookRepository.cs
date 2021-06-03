using Bookstore.Data.Interfaces;
using Bookstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bookstore.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> books = new List<Book>() {
            new Book { Id=1, Title="The Girl On The Train", Author="Hawkin, Paula",PublicationYears=2010,IsAvailaible=true,CallNumber="03323675619" },
            new Book { Id=2, Title="Rogue, Lawyer", Author="Grisham John",PublicationYears=2013,IsAvailaible=true,CallNumber="03343675619" },
            new Book { Id=3, Title="All The Light We Can Not See", Author="Doer, Anthony",PublicationYears=2016,IsAvailaible=true,CallNumber="03343675658" }
        }; 

        public List<Book> GetAllBook()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.FirstOrDefault(x=>x.Id==id);
        }
    }
}
