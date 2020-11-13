using Ftx.Net.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Orders
{
    public class FtxOrder
    {
        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("filledSize")]
        public decimal FilledSize { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("avgFillPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AvgFillPrice { get; set; }

        [JsonProperty("side"), JsonConverter(typeof(FtxOrderSideConverter))]
        public FtxOrderSide Side { get; set; }

        [JsonProperty("size")]
        public decimal Size { get; set; }

        [JsonProperty("status"), JsonConverter(typeof(FtxOrderStatusConverter))]
        public FtxOrderStatus Status { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore),JsonConverter(typeof(FtxOrderTypeConverter))]
        public FtxOrderType Type { get; set; }

        [JsonProperty("reduceOnly")]
        public bool ReduceOnly { get; set; }

        [JsonProperty("ioc")]
        public bool Ioc { get; set; }

        [JsonProperty("postOnly")]
        public bool PostOnly { get; set; }

        [JsonProperty("clientId")]
        public string ClientOrderId { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        /// [DEPRECATED] order ID if this order has triggered; otherwise null
        /// </summary>
        [JsonProperty("orderId", NullValueHandling = NullValueHandling.Ignore)]
        public long? OrderId { get; set; }

        /// <summary>
        /// price of the order sent when this stop loss triggered
        /// </summary>
        [JsonProperty("orderPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OrderPrice { get; set; }

        [JsonProperty("trailStart", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TrailStart { get; set; }

        [JsonProperty("trailValue", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TrailValue { get; set; }

        [JsonProperty("triggerPrice", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TriggerPrice { get; set; }

        [JsonProperty("triggeredAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TriggeredAt { get; set; }

        [JsonProperty("orderStatus", NullValueHandling = NullValueHandling.Ignore)]
        public FtxOrderStatus? OrderStatus { get; set; }

        [JsonProperty("retryUntilFilled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RetryUntilFilled { get; set; }

        [JsonProperty("market")]
        public string Symbol { get; set; }

        /// <summary>
        /// Values are market, limit for conditional orders
        /// </summary>
        [JsonProperty("orderType"), JsonConverter(typeof(FtxOrderTypeConverter))]
        public FtxOrderType OrderType { get; set; }


        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Price { get; set; }

        [JsonProperty("remainingSize", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? RemainingSize { get; set; }

     

    }
}
