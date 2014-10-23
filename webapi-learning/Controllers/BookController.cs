using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapi_learning.Filters;
using webapi_learning.Models;

namespace webapi_learning.Controllers
{
    public class BookController : ApiController
    {
        [Route("api/books")]
        public IEnumerable<Book> GetBooks()
        {
            return null;
        }

        [Route("api/books/{id:int}")]
        public Book GetBook(int id) { return null; }

        [Route("api/books")]
        [HttpPost]
        public HttpResponseMessage CreateBook(Book book) { return null; }
    }
}