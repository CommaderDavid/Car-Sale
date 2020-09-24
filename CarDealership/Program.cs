using Microsoft.AspNetCore.Hosting;
using System.IO;
using CarDealership.Models;

namespace CarDealership
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car x = new Car("1974 Volkswagen Thing", 1100, 368792);
            Car yugo = new Car("1980 Yugo Koral", 700, 56000);
            Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
            Car amc = new Car("1976 AMC Pacer", 400, 198000);

            var host = new WebHostBuilder()
              .UseKestrel()
              .UseContentRoot(Directory.GetCurrentDirectory())
              .UseIISIntegration()
              .UseStartup<Startup>()
              .Build();

            host.Run();
        }
    }
}