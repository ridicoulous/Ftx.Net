using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Orders
{
    public class FtxUpdateOrderRequest
    {
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? NewPrice { get; set; }
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? NewSize { get; set; }        
        public string NewClientOrderId { get; set; } 
        public long? OrderId { get; set; }
        public string OldClientOrderId { get; set; }
        [JsonProperty("triggerPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? NewTriggerPrice { get; set; }
        [JsonProperty("orderPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? NewOrderPriceForLimitStopOrTake { get; set; }
        [JsonProperty("trailValue", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? NewTrailValue { get; set; }
    }
}
