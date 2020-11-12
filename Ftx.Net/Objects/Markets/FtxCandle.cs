using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects.Markets
{   
    public  class FtxCandle
    {
        [JsonProperty("close")]
        public decimal Close { get; set; }

        [JsonProperty("high")]
        public long High { get; set; }

        [JsonProperty("low")]
        public decimal Low { get; set; }

        [JsonProperty("open")]
        public decimal Open { get; set; }

        [JsonProperty("startTime")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("volume")]
        public decimal Volume { get; set; }
    }
}
