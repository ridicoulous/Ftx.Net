using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Wallet
{
    public class FtxCoinInfo
    {
        [JsonProperty("bep2Asset")]
        public string Bep2Asset { get; set; }

        [JsonProperty("canConvert")]
        public bool CanConvert { get; set; }

        [JsonProperty("canDeposit")]
        public bool CanDeposit { get; set; }

        [JsonProperty("canWithdraw")]
        public bool CanWithdraw { get; set; }

        [JsonProperty("collateral")]
        public bool Collateral { get; set; }

        [JsonProperty("collateralWeight")]
        public decimal CollateralWeight { get; set; }

        [JsonProperty("creditTo")]
        public string CreditTo { get; set; }

        [JsonProperty("erc20Contract")]
        public string Erc20Contract { get; set; }

        [JsonProperty("fiat")]
        public bool IsFiat { get; set; }

        [JsonProperty("hasTag")]
        public bool HasTag { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isToken")]
        public bool IsToken { get; set; }

        [JsonProperty("methods")]
        public List<string> Methods { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("splMint")]
        public string SplMint { get; set; }

        [JsonProperty("trc20Contract")]
        public string Trc20Contract { get; set; }

        [JsonProperty("usdFungible")]
        public bool UsdFungible { get; set; }
    }
}
