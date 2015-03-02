using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace Any.WebConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = ConfigurationManager.AppSettings["url"];
            using (WebApp.Start<Startup>(url))
            {
                Process.Start(url); // Launch the browser.
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
