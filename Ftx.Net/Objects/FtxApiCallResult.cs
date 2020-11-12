using CryptoExchange.Net.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Ftx.Net.Objects
{
    public class FtxApiCallResult<TData>
    {      

        [JsonProperty("success")]
        public bool IsSuccess { get; set; }
        [JsonProperty("result")]
        public TData Data { get; set; }
    }
}
