using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Data.Models;
using Bookstore.Data.Interfaces;
using Bookstore.Data.Repositories;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        /* public List<Book> books = new List<Book>() {
             new Book { Id=1, Title="The Girl On The Train", Author="Hawkin, Paula",PublicationYears=2010,IsAvailaible=true,CallNumber="03323675619" },
             new Book { Id=2, Title="Rogue, Lawyer", Author="Grisham John",PublicationYears=2013,IsAvailaible=true,CallNumber="03343675619" },
             new Book { Id=1, Title="All The Light We Can Not See", Author="Doer, Anthony",PublicationYears=2016,IsAvailaible=true,CallNumber="03343675658" }
         };*/

        private BookRepository books = new BookRepository();

        [HttpGet]

        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books.GetAllBook();
        }

        [HttpGet("{id}")] 

        public ActionResult<Book> GetBook(int id)
        {
            var book = books.GetBook(id); 

            if (book==null)
            {
                return NotFound();
            }

            return book;
        }





    } 

     



}
