using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Wallet
{
    public class FtxGenerateAddressResult
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }
}
