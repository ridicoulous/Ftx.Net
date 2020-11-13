using Ftx.Net.Converters;
using Ftx.Net.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Orders
{
    public abstract class FtxBasePlaceOrderRequest : IFtxPlaceOrderReqest
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="symbol">market name</param>
        /// <param name="side">buy or sell</param>
        /// <param name="price"></param>
        /// <param name="type">limit or market</param>
        /// <param name="size"></param>
        /// <param name="reduceOnly">should only reduce position amount</param>
        /// <param name="ioc">immediate or cancel</param>
        /// <param name="postOnly">will be only maker</param>
        /// <param name="clientId">optional clients order id</param>
        public FtxBasePlaceOrderRequest(string symbol, FtxOrderSide side, FtxOrderType type, decimal size, bool reduceOnly=false, string clientId=null)
        {
            Symbol = symbol ?? throw new ArgumentNullException(nameof(symbol));
            Side = side;          
            Type = type;
            Size = size;
            ReduceOnly = reduceOnly;
            ClientId = clientId;
        }

        [JsonProperty("market")]
        public string Symbol { get; set; }

        [JsonProperty("side"),JsonConverter(typeof(FtxOrderSideConverter))]
        public FtxOrderSide Side { get; set; }

        [JsonProperty("type"), JsonConverter(typeof(FtxOrderTypeConverter))]
        public FtxOrderType Type { get; set; }

        [JsonProperty("size")]
        public decimal Size { get; set; }

        [JsonProperty("reduceOnly")]
        public bool ReduceOnly { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }
    }
}
