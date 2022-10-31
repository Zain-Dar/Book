using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Book> Books{ get; private set; }
        public JsonBookFile BookService;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, JsonBookFile bookService)
        {
            _logger = logger;
            BookService = bookService;
        }

        public void OnGet()
        {
            Books = BookService.getBookRecords();
        }
    }
}
