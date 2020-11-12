using Ftx.Net.Converters;
using Ftx.Net.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Interfaces
{
    public interface IFtxPlaceOrderReqest
    {
        [JsonProperty("market")]
        string Symbol { get; set; }

        [JsonProperty("side"), JsonConverter(typeof(FtxOrderSideConverter))]
        FtxOrderSide Side { get; set; }

        [JsonProperty("price")]
        decimal Price { get; set; }

        [JsonProperty("type"), JsonConverter(typeof(FtxOrderTypeConverter))]
        FtxOrderType Type { get; set; }

        [JsonProperty("size")]
        decimal Size { get; set; }

        [JsonProperty("reduceOnly")]
        bool ReduceOnly { get; set; }

        [JsonProperty("ioc")]
        bool Ioc { get; set; }

        [JsonProperty("postOnly")]
        bool PostOnly { get; set; }

        [JsonProperty("clientId")]
        string ClientId { get; set; }
    }
}
