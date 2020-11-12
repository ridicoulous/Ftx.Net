using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects
{
    public class FtxTrade
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("liquidation")]
        public bool IsLiquidation { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }

        [JsonProperty("size")]
        public decimal Size { get; set; }

        [JsonProperty("time")]
        public DateTimeOffset Timestamp { get; set; }
    }
}
