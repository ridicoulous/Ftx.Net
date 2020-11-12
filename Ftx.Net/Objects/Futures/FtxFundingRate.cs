using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Futures
{
    public class FtxFundingRate
    {
        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("rate")]
        public decimal Rate { get; set; }

        [JsonProperty("time")]
        public DateTimeOffset Time { get; set; }
    }
}
