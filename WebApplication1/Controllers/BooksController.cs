using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace Book_Shop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        JsonBookFile BookService { get; }
        public BooksController(JsonBookFile bookService)
        {
            this.BookService = bookService;
        }
        [HttpGet]
        public IEnumerable<Book> get()
        {
            return this.BookService.getBookRecords();
        }

    }
}
