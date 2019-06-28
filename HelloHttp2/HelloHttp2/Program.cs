using HttpTwo;
using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;

namespace HelloHttp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            sendHttp2().ContinueWith((t1)=>
            {
                Console.WriteLine("HTTP2 resend complete!");
            });

            // Await our response
            // var response = await http2.Send(uri, HttpMethod.Get, headers, data);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static async Task sendHttp2()
        {
            // Uri to request
            var uri = new Uri("https://localhost:8443/");

            // Create a Http2Client
            var http2 = new Http2Client(uri);

            // Specify any custom headers
            var headers = new NameValueCollection();
            headers.Add("some-header", "value");

            // For some requests you may have a request body
            byte[] data = null;

            http2.Connect();
            //var response = await http2.Send(uri, HttpMethod.Get, headers, data);
        }
    }
}
