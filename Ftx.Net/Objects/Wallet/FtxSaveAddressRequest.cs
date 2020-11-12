using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Wallet
{
    public class FtxSaveAddressRequest
    {
        public FtxSaveAddressRequest(string coinName, string address, string addressName, bool isPrimetrust, string tag=null)
        {
            CoinName = coinName ?? throw new ArgumentNullException(nameof(coinName));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            AddressName = addressName ?? throw new ArgumentNullException(nameof(addressName));
            IsPrimetrust = isPrimetrust;
            Tag = tag;
        }

        [JsonProperty("coin")]
        public string CoinName { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("addressName")]
        public string AddressName { get; set; }
        [JsonProperty("isPrimetrust")]
        public bool IsPrimetrust { get; set; }
        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}
