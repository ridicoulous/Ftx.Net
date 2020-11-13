using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Orders
{
    public class FtxConditionalOrerTrigger
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("filledSize")]
        public decimal FilledSize { get; set; }

        [JsonProperty("orderSize")]
        public decimal OrderSize { get; set; }

        [JsonProperty("orderId")]
        public long OrderId { get; set; }

        [JsonProperty("time")]
        public DateTimeOffset Time { get; set; }
    }
}
