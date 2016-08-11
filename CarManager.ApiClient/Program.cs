using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.ApiClient
{
    class Program
    {


        public class Book
        {
            public string name { get; set; }
            public float price { get; set; }
        }

        static void Main(string[] args)
        {
            //HttpClient client = new HttpClient(new MyHandlers.MyMessageHandler());
            //HttpClient client = HttpClientFactory.Create(new MyHandlers.MyMessageHandler(), new MyHandlers.MyMessageHandler1());

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:11128/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(mediaType: "application/json"));

            var msg = client.GetAsync("api/Default").Result;

            if (msg.IsSuccessStatusCode)
            {
                var result = msg.Content.ReadAsAsync<List<Book>>().Result;
                Console.WriteLine(result.Count);
            }

            Console.ReadKey();
        }
    }
}
