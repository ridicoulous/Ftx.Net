using Ftx.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Orders
{
    public class FtxPlaceStopOrTakeOrderRequest : FtxBasePlaceOrderRequest
    {
        /// <summary>
        /// Use it to place Stop or Take orders
        /// </summary>
        /// <param name="market">symbol</param>
        /// <param name="isStop">is true, it will be stop order instead take</param>
        /// <param name="side"></param>
        /// <param name="size"></param>
        /// <param name="triggerPrice"></param>
        /// <param name="limitPrice">if it not null, stop or take order will be limit instead market</param>
        /// <param name="reduceOnly"></param>
        public FtxPlaceStopOrTakeOrderRequest(string market, bool isStop, FtxOrderSide side, decimal size, decimal triggerPrice, decimal? limitPrice = null, bool reduceOnly = false,string clientOrderId=null) : base(market, side, isStop ? FtxOrderType.Stop : FtxOrderType.TakeProfit,size,reduceOnly,clientOrderId)
        {          
            TriggerPrice = triggerPrice;
            LimitPrice = limitPrice;
        }
        [JsonProperty("triggerPrice")]
        public decimal TriggerPrice { get; set; }
        [JsonProperty("orderPrice")]
        public decimal? LimitPrice { get; set; }
    }
}
