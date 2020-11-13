using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.FilterRequests
{
    public class FtxFilterRequest
    {
        public FtxFilterRequest()
        {

        }
        public FtxFilterRequest(string symbol, DateTime? from, DateTime? to, FtxOrderSide? side, FtxOrderType? type, FtxOrderType? orderType, long? limit)
        {
            Symbol = symbol;
            From = from;
            To = to;
            Side = side;
            Type = type;
            OrderType = orderType;
            Limit = limit;
        }

        [JsonProperty("market", NullValueHandling = NullValueHandling.Ignore)]
        public string Symbol { get; set; }
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? From { get; set; }
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? To { get; set; }
        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public FtxOrderSide? Side { get; set; }
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public FtxOrderType? Type { get; set; }
        [JsonProperty("orderType", NullValueHandling = NullValueHandling.Ignore)]
        public FtxOrderType? OrderType { get; set; }
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public long? Limit { get; set; } = 100;
    }
}
