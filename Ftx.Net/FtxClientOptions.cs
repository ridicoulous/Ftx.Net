using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Logging;
using CryptoExchange.Net.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Ftx.Net
{

    public class FtxClientOptions : RestClientOptions
    {
        public FtxClientOptions() : base("https://ftx.com/api")
        {
            this.LogVerbosity = CryptoExchange.Net.Logging.LogVerbosity.Debug;
            LogWriters = new List<System.IO.TextWriter>() { new DebugTextWriter() };
        }
      
        public FtxClientOptions(HttpClient client) : base(client, "https://ftx.com/api")
        {
            this.LogVerbosity = CryptoExchange.Net.Logging.LogVerbosity.Debug;
            LogWriters = new List<System.IO.TextWriter>() { new DebugTextWriter() };

        }


        public void SetApiCredentials(ApiCredentials credentials)
        {
            ApiCredentials = credentials;
        }

    }
}
