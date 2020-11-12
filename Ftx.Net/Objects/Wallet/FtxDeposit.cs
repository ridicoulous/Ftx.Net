using Ftx.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Wallet
{
    public class FtxDeposit
    {
        [JsonProperty("coin")]
        public string Coin { get; set; }

        [JsonProperty("confirmations")]
        public long Confirmations { get; set; }

        [JsonProperty("confirmedTime")]
        public DateTimeOffset ConfirmedTime { get; set; }

        [JsonProperty("fee")]
        public long Fee { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("sentTime")]
        public DateTimeOffset SentTime { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("status"),JsonConverter(typeof(FtxDepositMethodConverter))]
        public FtxDepositStatus Status { get; set; }

        [JsonProperty("time")]
        public DateTimeOffset Time { get; set; }

        [JsonProperty("txid")]
        public string Txid { get; set; }
    }
}
