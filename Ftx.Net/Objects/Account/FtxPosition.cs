using Ftx.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Account
{
    public class FtxPosition
    {
        /// <summary>
        /// Amount that was paid to enter this position, equal to size * entry_price. Positive if long, negative if short.
        /// </summary>
        [JsonProperty("cost")]
        public decimal Cost { get; set; }
        /// <summary>
        /// 	Average cost of this position after pnl was last realized: whenever unrealized pnl gets realized, this field gets set to mark price, unrealizedPnL is set to 0, and realizedPnl changes by the previous value for unrealizedPnl.
        /// </summary>
        [JsonProperty("entryPrice")]
        public decimal EntryPrice { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("initialMarginRequirement")]
        public decimal InitialMarginRequirement { get; set; }
        /// <summary>
        /// Cumulative size of all open bids
        /// </summary>
        [JsonProperty("longOrderSize")]
        public decimal LongOrderSize { get; set; }

        [JsonProperty("maintenanceMarginRequirement")]
        public decimal MaintenanceMarginRequirement { get; set; }

        [JsonProperty("netSize")]
        public decimal NetSize { get; set; }

        [JsonProperty("openSize")]
        public decimal OpenSize { get; set; }

        [JsonProperty("realizedPnl")]
        public decimal RealizedPnl { get; set; }
        /// <summary>
        /// Cumulative size of all open offers
        /// </summary>
        [JsonProperty("shortOrderSize")]
        public decimal ShortOrderSize { get; set; }

        [JsonProperty("side"),JsonConverter(typeof(FtxPositionSideConverter))]
        public FtxPositionSide Side { get; set; }

        [JsonProperty("size")]
        public decimal Size { get; set; }

        [JsonProperty("unrealizedPnl")]
        public long UnrealizedPnl { get; set; }
    }
}
