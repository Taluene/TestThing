using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestThing.Models;

namespace TestThing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public List<Book> books = new List<Book>()
        {
            new Book { Id = 1, Title = "title 1", Author = "Pratt, Kevin", PublicationYear = 2003, IsAvailable = true, CallNumber = "1a"},
            new Book { Id = 2, Title = "title 2", Author = "Kratzert, Andy", PublicationYear = 2003, IsAvailable = false, CallNumber = "1s"},
            new Book { Id = 3, Title = "title 3", Author = "Kratsky, Ashley", PublicationYear = 1996, IsAvailable = true, CallNumber = "1d"},
            new Book { Id = 4, Title = "title 4", Author = "Donaldson, Ben", PublicationYear = 1986, IsAvailable = false, CallNumber = "1f"},
            new Book { Id = 5, Title = "title 5", Author = "Melvin, Belvin", PublicationYear = 1955, IsAvailable = true, CallNumber = "1b"}
        };

        [HttpGet]

        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            return books;
        }

        [HttpGet("{id}")]

        public ActionResult<Book> GetBook(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<Book>> GetDatBook()
        //{
        //    var book = books.FirstOrDefault(x => x.Id = 1);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }
        //    return book;
        //}



        [HttpPost]

        public ActionResult<IEnumerable<Book>> PostBook(int id, string title, string author, int publicationYear, bool isAvailable, string callNumber)
        {
            books.Add(
            new Book { Id = id, Title = title, Author = author, PublicationYear = publicationYear, IsAvailable = isAvailable, CallNumber = callNumber }
            );
            return books;
        }
      
    }
}
