using Ftx.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Wallet
{
    public class FtxWithdrawal
    {
        [JsonProperty("coin")]
        public string Coin { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("tag")]
        public object Tag { get; set; }

        [JsonProperty("fee")]
        public long Fee { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("status"),JsonConverter(typeof(FtxWithdrawalStatusConverter))]
        public FtxWithdrawalStatus Status { get; set; }

        [JsonProperty("time")]
        public DateTimeOffset Time { get; set; }

        [JsonProperty("txid")]
        public string Txid { get; set; }
    }
}
