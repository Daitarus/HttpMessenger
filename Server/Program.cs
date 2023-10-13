using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string mainMessage = @"<!DOCTYPE html>
            <html>
                <head>
                    <meta charset='utf8'>
                    <title>Мой сайт</title>
                </head>
                <body>
                    <h2>Привет!</h2>
                </body>
            </html>";

            

            MyServer myServer = new MyServer(mainMessage, "http://localhost:8888/");

            PrintStart(myServer.Start());

            while (true)
            {
                var requestTask = myServer.PerformCommunication();
                requestTask.Wait();
            }

            PrintStop(myServer.Stop());
        }

        private static void PrintStart(bool isStarted)
        {
            string printLine = isStarted ? "Сервер запущен" : "Сервер не запущен";
            Console.WriteLine(printLine);
        }
        private static void PrintStop(bool isStoped)
        {
            string printLine = isStoped ? "Сервер остановлен" : "Сервер не остановлен";
            Console.WriteLine(printLine);
        }
    }

    public class MyServer : IDisposable
    {
        private readonly HttpListener server = new HttpListener();

        public string MainResponse;

        public MyServer() : this(string.Empty, "http://localhost:8888/") { }

        public MyServer(string mainResponce, string mainUri)
        {
            MainResponse = mainResponce;
            server.Prefixes.Add(mainUri);
        }

        public bool Start()
        {
            server.Start();
            return server.IsListening;
        }

        public async Task PerformCommunication()
        {
            var context = await server.GetContextAsync();
            var response = context.Response;

            byte[] buffer = Encoding.UTF8.GetBytes(MainResponse);
            response.ContentLength64 = buffer.Length;
            using Stream output = response.OutputStream;

            await output.WriteAsync(buffer);
            await output.FlushAsync();
        }

        public bool Stop()
        {
            server.Stop();
            return !server.IsListening;
        }

        public void Dispose()
        {
            server.Close();
        }
    }
}
