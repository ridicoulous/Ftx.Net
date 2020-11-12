using Ftx.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Wallet
{
    public class FtxAirdrop
    {
        [JsonProperty("coin")]
        public string Coin { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("time")]
        public DateTimeOffset Time { get; set; }

        [JsonProperty("status"),JsonConverter(typeof(FtxAirdropStatusConverter))]
        public FtxAirdropStatus Status { get; set; }
    }
}
