using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Book
    {
        [JsonPropertyName("id")]
        public int book_id { get; set; }
       
        [JsonPropertyName("name")]
        public string book_name { get; set; }
        
        [JsonPropertyName("image")]
        public string book_image { get; set; }

        public override string ToString()
        {
          return  JsonSerializer.Serialize<Book>(this);
        }

    }
   
}
