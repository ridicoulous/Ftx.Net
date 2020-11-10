using Ftx.Net.Interfaces;
using System;
using System.Threading.Tasks;

namespace Ftx.Net.ConsoleApp
{
    class Program
    {
        static async     Task Main(string[] args)
        {
            var ftc = new FtxClient();
            var ob = await ftc.GetAllMarketsAsync();
            Console.WriteLine();
        }
    }
}
