using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class JsonBookFile
    {
        public JsonBookFile(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        public String JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data",
                    "books.Json");

            }
        }

        public IEnumerable<Book> getBookRecords()
        {
            using (var jason_file = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<Book[]>(jason_file.ReadToEnd());
            }
        }

       
    }

}
