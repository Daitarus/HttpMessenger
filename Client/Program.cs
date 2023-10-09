using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class Program
    {
        public async static Task Main(string[] args)
        {
            var myClient = new MyClient();
            Console.WriteLine("Приложение начало работу");
            await myClient.Start();
            Console.WriteLine("Приложение завершило работу");
        }
    }

    public class MyClient
    {
        public async Task Start()
        {
            for (int i = 0; i < 10; i++)
            {
                using (var client = new HttpClient())
                {
                    using var result = await client.GetAsync("https://google.com");
                    Console.WriteLine(result.StatusCode);
                }
            }
        }
    }
}
