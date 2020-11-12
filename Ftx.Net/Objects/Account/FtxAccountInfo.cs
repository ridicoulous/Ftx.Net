using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Account
{
    public class FtxAccountInfo
    {
        /// <summary>
        /// whether or not the account is a registered backstop liquidity provider
        /// </summary>
        [JsonProperty("backstopProvider")]
        public bool IsBackstopProvider { get; set; }
        /// <summary>
        /// amount of collateral
        /// </summary>
        [JsonProperty("collateral")]
        public decimal Collateral { get; set; }
        /// <summary>
        /// amount of free collateral
        /// </summary>
        [JsonProperty("freeCollateral")]
        public decimal FreeCollateral { get; set; }
        /// <summary>
        /// average of initialMarginRequirement for individual futures, weighed by position notional. Cannot open new positions if openMarginFraction falls below this value.
        /// </summary>
        [JsonProperty("initialMarginRequirement")]
        public decimal InitialMarginRequirement { get; set; }
        /// <summary>
        /// Max account leverage
        /// </summary>
        [JsonProperty("leverage")]
        public long Leverage { get; set; }
        /// <summary>
        /// True if the account is currently being liquidated
        /// </summary>
        [JsonProperty("liquidating")]
        public bool IsLiquidatingNow { get; set; }
        /// <summary>
        /// Average of maintenanceMarginRequirement for individual futures, weighed by position notional. Account enters liquidation mode if margin fraction falls below this value.
        /// </summary>
        [JsonProperty("maintenanceMarginRequirement")]
        public decimal MaintenanceMarginRequirement { get; set; }

        [JsonProperty("makerFee")]
        public decimal MakerFee { get; set; }
        /// <summary>
        /// ratio between total account value and total account position notional.
        /// </summary>
        [JsonProperty("marginFraction")]
        public decimal MarginFraction { get; set; }
        /// <summary>
        /// Ratio between total realized account value and total open position notional
        /// </summary>
        [JsonProperty("openMarginFraction")]
        public decimal OpenMarginFraction { get; set; }

        [JsonProperty("takerFee")]
        public decimal TakerFee { get; set; }
        /// <summary>
        /// 	total value of the account, using mark price for positions
        /// </summary>
        [JsonProperty("totalAccountValue")]
        public decimal TotalAccountValue { get; set; }
        /// <summary>
        /// total size of positions held by the account, using mark price
        /// </summary>
        [JsonProperty("totalPositionSize")]
        public decimal TotalPositionSize { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("positions")]
        public List<FtxPosition> Positions { get; set; }
    }
    
}
