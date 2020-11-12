using Ftx.Net.Interfaces;
using System;
using System.Threading.Tasks;

namespace Ftx.Net.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var ftc = new FtxClient();
      
            var trades = await ftc.GetTradesAsync("BTC-PERP", 1000,new DateTime(2020,8,11), new DateTime(2020,8,11,0,2,22));
            var futures = await ftc.Geta("BTC-PERP", 1000, new DateTime(2020, 8, 11), new DateTime(2020, 8, 11, 0, 2, 22));

            Console.WriteLine();
        }
    }
}
