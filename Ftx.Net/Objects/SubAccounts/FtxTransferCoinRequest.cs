using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects
{
    public class FtxTransferCoinRequest
    {
        public FtxTransferCoinRequest(string coin, decimal size, string source, string destination)
        {
            Coin = coin ?? throw new ArgumentNullException(nameof(coin));
            Size = size;
            Source = source ?? throw new ArgumentNullException(nameof(source));
            Destination = destination ?? throw new ArgumentNullException(nameof(destination));
        }

        [JsonProperty("coin")]
        public string Coin { get; set; }

        [JsonProperty("size")]
        public decimal Size { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
