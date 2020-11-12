using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Futures
{
    public class FtxFutureStats
    {
        [JsonProperty("volume")]
        public decimal Volume { get; set; }

        [JsonProperty("nextFundingRate")]
        public decimal NextFundingRate { get; set; }

        [JsonProperty("nextFundingTime")]
        public DateTimeOffset NextFundingTime { get; set; }

        [JsonProperty("expirationPrice")]
        public decimal ExpirationPrice { get; set; }

        [JsonProperty("predictedExpirationPrice")]
        public decimal PredictedExpirationPrice { get; set; }

        [JsonProperty("strikePrice")]
        public decimal StrikePrice { get; set; }

        [JsonProperty("openInterest")]
        public decimal OpenInterest { get; set; }
    }
}
