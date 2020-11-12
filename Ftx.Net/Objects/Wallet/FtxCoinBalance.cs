using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Wallet
{
    public class FtxCoinBalance
    {
        [JsonProperty("coin")]
        public string Symbol { get; set; }

        [JsonProperty("free")]
        public decimal Free { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }
    }
}
