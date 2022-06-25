using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS
{
    public class Program
    {
        private static event EventHandler evt;
        private static void HandleEvent(object sender, EventArgs eveAargs)
        {

        }
        public static void Main(string[] args)
        {


            evt += (sender, eveArg) =>
            {
                System.Diagnostics.Debug.WriteLine("HelloWorld");
            };
            evt.Invoke(null, new EventArgs());
            // CreateHostBuilder(args).Build().Run();
        }


        ~Program()
        {
            evt -= (sender, eveArg) =>
            {
                System.Diagnostics.Debug.WriteLine("HelloWorld");
            };
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
