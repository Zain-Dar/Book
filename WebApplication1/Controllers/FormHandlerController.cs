using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace Book_Shop.Controllers
{
    [Route("[controller]")]
    public class FormHandlerController : Controller
    {
        JsonBookFile BookService;
        public FormHandlerController(JsonBookFile bookService)
        {
            this.BookService = bookService;
        }
        [HttpGet]
        public string Get(int id, string name,string image )
        {
            Book obj = new Book();
            obj.book_id = id;
            obj.book_name = name;
            obj.book_image = image;
            IEnumerable<Book> BooksData = BookService.getBookRecords();
            List<Book> listofBooks = BooksData.ToList();
            listofBooks.Add(obj);
            return JsonSerializer.Serialize<List<Book>>(listofBooks);
        }
    }
}
