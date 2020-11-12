using Newtonsoft.Json;

namespace Ftx.Net.Objects.Orders
{
    public class FtxPlaceTrailingOrderRequest : FtxBasePlaceOrderRequest
    {
        /// <summary>
        /// Use it to place trailing stop order
        /// </summary>
        /// <param name="market"></param>
        /// <param name="side"></param>
        /// <param name="size"></param>
        /// <param name="trailingValue">negative for "sell"; positive for "buy"</param>
        /// <param name="reduceOnly"></param>
        public FtxPlaceTrailingOrderRequest(string market, FtxOrderSide side, decimal size, decimal trailingValue,  bool reduceOnly = false, string clientOrderId=null) 
            : base(market, side, FtxOrderType.TrailingStop,size, reduceOnly,clientOrderId)
        {
            TrailValue = trailingValue;           
        }
        /// <summary>
        /// negative for "sell"; positive for "buy"
        /// </summary>
        [JsonProperty("trailValue")]
        public decimal TrailValue { get; set; }
     
    }
}
