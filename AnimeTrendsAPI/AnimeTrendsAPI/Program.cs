using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace AnimeTrendsAPI
{
    public class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            WebApp.Start<Startup>(url: baseAddress);
            Console.ReadLine();
        }
    }
}
