using DnsClient;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopMarket.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)

                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
            
           // .UseSerilog(Logging.ConfigureLogger);
    }


    //public void ConfigureServices(IServiceCollection services)
    //{
    //    var serviceProvider = services.BuildServiceProvider();
    //    var logger = serviceProvider.GetService<ILogger<AnyClass>>();
    //    services.AddSingleton(typeof(ILogger), logger);
    //    ...
    // }
}
