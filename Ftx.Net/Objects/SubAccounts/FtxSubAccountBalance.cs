using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.SubAccounts
{
    public class FtxSubAccountBalance
    {
        [JsonProperty("coin")]
        public string Coin { get; set; }

        [JsonProperty("free")]
        public decimal Free { get; set; }

        [JsonProperty("total")]
        public decimal Total { get; set; }
    }
}
