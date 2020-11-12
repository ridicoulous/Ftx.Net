using Newtonsoft.Json;
using System;

namespace Ftx.Net.Objects.Orders
{
    public class FtxPlaceSimpleOrderRequest : FtxBasePlaceOrderRequest
    {
        public FtxPlaceSimpleOrderRequest(string symbol,
                                          FtxOrderSide side,
                                          FtxOrderType type,
                                          decimal size,
                                          decimal price,
                                          bool reduceOnly = false,
                                          bool ioc = false,
                                          bool postOnly = false,
                                          string clientId = null) 
            : base(symbol, side, type, size, reduceOnly,  clientId)
        {
            if(type==FtxOrderType.Stop|| type == FtxOrderType.TakeProfit || type == FtxOrderType.TrailingStop)
            {
                throw new Exception("Simple order can be only Limit or Market");
            }
            Ioc = ioc;
            PostOnly = postOnly;
            Price = price;

        }
        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("ioc")]
        public bool Ioc { get; set; }

        [JsonProperty("postOnly")]
        public bool PostOnly { get; set; }
    }
}
