using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStarterBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9009/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Serwer działa");
                Console.ReadLine();
            }
        }
    }
}
