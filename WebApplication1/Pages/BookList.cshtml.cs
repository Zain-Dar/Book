using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace Book_Shop.Pages
{
    public class BookListModel : PageModel
    {
        JsonBookFile BookService;
        public IEnumerable<Book> Books;
        public BookListModel(JsonBookFile bookService)
        {
            this.BookService = bookService;
        }
        public void OnGet()
        {
            Books = BookService.getBookRecords();
        }
    }
}
