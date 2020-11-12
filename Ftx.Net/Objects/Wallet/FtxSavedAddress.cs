using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Wallet
{
    public class FtxSavedAddress
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("coin")]
        public string Coin { get; set; }

        [JsonProperty("fiat")]
        public bool Fiat { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("isPrimetrust")]
        public bool IsPrimetrust { get; set; }

        [JsonProperty("lastUsedAt")]
        public DateTimeOffset LastUsedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tag")]
        public object Tag { get; set; }

        [JsonProperty("whitelisted")]
        public bool Whitelisted { get; set; }
        /// <summary>
        /// Date after which the address has been whitelisted, null if the address has never been whitelisted or has been unwhitelisted
        /// </summary>
        [JsonProperty("whitelistedAfter")]
        public DateTimeOffset WhitelistedAfter { get; set; }
    }
}
