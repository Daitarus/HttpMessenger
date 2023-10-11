using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            using var client = new HttpClient();
            using var message = new HttpRequestMessage(HttpMethod.Get, "http://192.168.89.82:14567/");

            Console.WriteLine("Клиент готов...");
            Console.ReadKey();

            using var result = client.Send(message);
            Console.WriteLine(result.StatusCode);
        }

        public static void OldMain()
        {
            var myClient = new MyClient();

            Console.WriteLine("Приложение начало работу");
            Task task = myClient.GetAsync();
            myClient.Get();
            Console.WriteLine("Приложение завершило работу");

            task.Wait();
        }
    }

    public class MyClient
    {
        private HttpMessageHandler handler = new HttpClientHandler();

        public async Task GetAsync()
        {
            using (var client = new HttpClient(handler, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    using var result = await client.GetAsync("https://google.com");
                    Console.WriteLine(result.StatusCode + " Async");
                }
            }
        }

        public void Get()
        {
            using (var client = new HttpClient(handler, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    using var message = new HttpRequestMessage(HttpMethod.Get, "https://google.com");
                    using var result = client.Send(message);
                    Console.WriteLine(result.StatusCode);
                }
            }
        }
    }
}
