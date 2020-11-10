using CryptoExchange.Net.Converters;
using CryptoExchange.Net.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects
{
    public class FtxOrderBook
    {
        [JsonProperty("asks")]
        public List<FtxOrderBookEntry> Asks { get; set; }
        [JsonProperty("bids")]
        public List<FtxOrderBookEntry> Bids { get; set; }

    }
    [JsonConverter(typeof(ArrayConverter))]
    public class FtxOrderBookEntry : ISymbolOrderBookEntry
    {
        [ArrayProperty(0)]
        public decimal Price { get; set; }
        [ArrayProperty(1)]
        public decimal Quantity { get; set; }
    
    }
}
