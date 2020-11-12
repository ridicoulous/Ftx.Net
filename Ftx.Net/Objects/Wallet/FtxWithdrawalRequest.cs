using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Wallet
{
    public class FtxWithdrawalRequest
    {
        public FtxWithdrawalRequest(string coin, decimal size, string address, string password, string code, string tag=null)
        {
            Coin = coin ?? throw new ArgumentNullException(nameof(coin));
            Size = size;
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Tag = tag;
            Password = password ?? throw new ArgumentNullException(nameof(password));
            Code = code ?? throw new ArgumentNullException(nameof(code));
        }

        [JsonProperty("coin")]
        public string Coin { get; set; }

        [JsonProperty("size")]
        public decimal Size { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("tag")]
        public object Tag { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("code")]
      
        public string Code { get; set; }
    }
}
