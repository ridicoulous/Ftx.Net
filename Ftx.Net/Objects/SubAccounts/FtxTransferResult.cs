using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects
{
    public class FtxTransferResult
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("coin")]
        public string Coin { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("time")]
        public DateTimeOffset Time { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
