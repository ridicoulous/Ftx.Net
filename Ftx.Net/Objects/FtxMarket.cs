using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects
{
    public partial class FtxMarket
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("baseCurrency")]
        public object BaseCurrency { get; set; }

        [JsonProperty("quoteCurrency")]
        public object QuoteCurrency { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("underlying")]
        public string Underlying { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("ask")]
        public double Ask { get; set; }

        [JsonProperty("bid")]
        public long Bid { get; set; }

        [JsonProperty("last")]
        public double Last { get; set; }

        [JsonProperty("postOnly")]
        public bool PostOnly { get; set; }

        [JsonProperty("priceIncrement")]
        public double PriceIncrement { get; set; }

        [JsonProperty("sizeIncrement")]
        public double SizeIncrement { get; set; }

        [JsonProperty("restricted")]
        public bool Restricted { get; set; }
    }
}
