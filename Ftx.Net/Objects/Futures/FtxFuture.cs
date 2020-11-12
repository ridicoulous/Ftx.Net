using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Futures
{
    public class FtxFuture
    {
        /// <summary>
        /// 	best ask on the orderbook
        /// </summary>
        [JsonProperty("ask")]
        public decimal? Ask { get; set; } = 0;
        /// <summary>
        /// best bid on the orderbook
        /// </summary>
        [JsonProperty("bid")]
        public decimal? Bid { get; set; } = 0;
        /// <summary>
        /// price change in the last hour
        /// </summary>
        [JsonProperty("change1h")]
        public decimal Change1H { get; set; }
        /// <summary>
        /// price change in the last 24 hours
        /// </summary>
        [JsonProperty("change24h")]
        public decimal Change24H { get; set; }
        /// <summary>
        /// price change since midnight UTC (beginning of day)
        /// </summary>
        [JsonProperty("changeBod")]
        public decimal ChangeBod { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("expired")]
        public bool IsExpired { get; set; }

        [JsonProperty("expiry")]
        public DateTimeOffset? Expiry { get; set; }

        [JsonProperty("expiryDescription")]
        public string ExpiryDescription { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("imfFactor")]
        public decimal ImfFactor { get; set; }

        [JsonProperty("index")]
        public decimal Index { get; set; }

        [JsonProperty("last")]
        public decimal Last { get; set; }

        [JsonProperty("lowerBound")]
        public decimal LowerBound { get; set; }

        [JsonProperty("marginPrice")]
        public decimal MarginPrice { get; set; }

        [JsonProperty("mark")]
        public decimal Mark { get; set; }

        [JsonProperty("moveStart")]
        public DateTimeOffset? MoveStart { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("perpetual")]
        public bool IsPerpetual { get; set; }

        [JsonProperty("positionLimitWeight")]
        public decimal PositionLimitWeight { get; set; }

        [JsonProperty("postOnly")]
        public bool IsPostOnly { get; set; }

        [JsonProperty("priceIncrement")]
        public decimal PriceIncrement { get; set; }

        [JsonProperty("sizeIncrement")]
        public decimal SizeIncrement { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("underlying")]
        public string Underlying { get; set; }

        [JsonProperty("underlyingDescription")]
        public string UnderlyingDescription { get; set; }

        [JsonProperty("upperBound")]
        public decimal UpperBound { get; set; }

        [JsonProperty("volume")]
        public decimal Volume { get; set; }
        /// <summary>
        /// USD volume in the last 24 hours
        /// </summary>
        [JsonProperty("volumeUsd24h")]
        public decimal VolumeUsd24H { get; set; }
    }
}
