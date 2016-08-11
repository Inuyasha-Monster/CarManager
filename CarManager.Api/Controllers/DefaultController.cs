using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace CarManager.Api.Controllers
{
    /// <summary>
    /// CodeTemplates
    /// </summary>
    /// <typeparam name=""></typeparam>
    public class DefaultController : ApiController
    {
        [HttpGet]
        public IEnumerable<Book> GetXXX()
        {
            var books = new List<Book>();
            books.Add(new Book { Name = "C++", Price = 100 });
            books.Add(new Book { Name = "C#", Price = 75 });
            books.Add(new Book { Name = "C", Price = 10 });
            books.Add(new Book { Name = "Java", Price = 70 });
            return books;
        }

        [HttpPost]
        public HttpResponseMessage TestJsonp(string callback)
        {
            var books = new List<Book>();
            books.Add(new Book { Name = "C++", Price = 100 });
            books.Add(new Book { Name = "C#", Price = 75 });
            books.Add(new Book { Name = "C", Price = 10 });
            books.Add(new Book { Name = "Java", Price = 70 });
            var data = Newtonsoft.Json.JsonConvert.SerializeObject(books);
            var funcation = $"{callback}({data})";
            var httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(funcation, Encoding.UTF8, "text/javascript")
            };
            return httpResponseMessage;
        }
    }

    public class Book
    {
        [StringLength(5, MinimumLength = 1)]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Book11111
    {
        [Newtonsoft.Json.JsonIgnore]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
