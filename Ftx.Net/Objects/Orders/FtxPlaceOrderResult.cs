//using Ftx.Net.Converters;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Ftx.Net.Objects.Orders
//{
//    public class FtxPlaceOrderResult
//    {
//        [JsonProperty("createdAt")]
//        public DateTimeOffset CreatedAt { get; set; }

//        [JsonProperty("future")]
//        public string Future { get; set; }

//        [JsonProperty("id")]
//        public long Id { get; set; }

//        [JsonProperty("market")]
//        public string Symbol { get; set; }

//        [JsonProperty("triggerPrice", NullValueHandling = NullValueHandling.Ignore)]
//        public decimal? TriggerPrice { get; set; }

//        [JsonProperty("orderId", NullValueHandling = NullValueHandling.Ignore)]
//        public long? OrderId { get; set; }

//        [JsonProperty("side"), JsonConverter(typeof(FtxOrderSideConverter))]
//        public FtxOrderSide Side { get; set; }

//        [JsonProperty("size")]
//        public long Size { get; set; }

//        [JsonProperty("status"),JsonConverter(typeof(FtxOrderStatusConverter))]
//        public FtxOrderStatus Status { get; set; }
//        /// <summary>
//        /// Values are market, limit for not conditional orders, or type for conditional (trailing, stop, take)
//        /// </summary>
//        [JsonProperty("type"),JsonConverter(typeof(FtxOrderTypeConverter))]
//        public FtxOrderType Type { get; set; }
//        /// <summary>
//        /// price of the order sent when this stop loss triggered
//        /// </summary>
//        [JsonProperty("orderPrice", NullValueHandling = NullValueHandling.Ignore)]
//        public decimal? OrderPrice { get; set; }

//        [JsonProperty("error")]
//        public string Error { get; set; }

//        [JsonProperty("triggeredAt", NullValueHandling = NullValueHandling.Ignore)]
//        public DateTimeOffset? TriggeredAt { get; set; }

//        [JsonProperty("reduceOnly")]
//        public bool ReduceOnly { get; set; }
//        /// <summary>
//        /// Values are market, limit for conditional orders
//        /// </summary>
//        [JsonProperty("orderType"), JsonConverter(typeof(FtxOrderTypeConverter))]
//        public FtxOrderType OrderType { get; set; }

//        [JsonProperty("retryUntilFilled", NullValueHandling = NullValueHandling.Ignore)]
//        public bool? RetryUntilFilled { get; set; }
//        [JsonProperty("filledSize")]
//        public decimal? FilledSize { get; set; }      

//        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
//        public decimal? Price { get; set; }

//        [JsonProperty("remainingSize", NullValueHandling = NullValueHandling.Ignore)]
//        public decimal? RemainingSize { get; set; }

//        [JsonProperty("ioc")]
//        public bool Ioc { get; set; }

//        [JsonProperty("postOnly")]
//        public bool PostOnly { get; set; }

//        [JsonProperty("clientId")]
//        public string ClientId { get; set; }
//    }
//}
