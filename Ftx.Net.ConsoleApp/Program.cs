using Ftx.Net.Interfaces;
using System;
using System.Threading.Tasks;
using Ftx.Net.Objects;
using Ftx.Net.Providers;

namespace Ftx.Net.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var ftc = new FtxClient(new FtxClientOptions(), new FtxAuthenticationProvider(new FtxApiCredentials("key", "secret")));

            var trades = await ftc.GetTradesAsync("BTC-PERP", 1000,new DateTime(2020,8,11), new DateTime(2020,8,11,0,2,22));
            //var futures = await ftc.Geta("BTC-PERP", 1000, new DateTime(2020, 8, 11), new DateTime(2020, 8, 11, 0, 2, 22));
            
            // Example with authentication
            var account = ftc.GetAccountInfo();
            Console.WriteLine();
        }
    }
}
