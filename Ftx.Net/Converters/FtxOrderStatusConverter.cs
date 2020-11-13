using CryptoExchange.Net.Converters;
using Ftx.Net.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Ftx.Net.Converters
{
    public class FtxOrderStatusConverter : BaseConverter<FtxOrderStatus>
    {
        public FtxOrderStatusConverter() : base(false)
        {
        }

        protected override List<KeyValuePair<FtxOrderStatus, string>> Mapping => new List<KeyValuePair<FtxOrderStatus, string>>()
        {
            new KeyValuePair<FtxOrderStatus, string>(FtxOrderStatus.Closed,"closed"),
            new KeyValuePair<FtxOrderStatus, string>(FtxOrderStatus.Open,"open"),
            new KeyValuePair<FtxOrderStatus, string>(FtxOrderStatus.Triggered,"triggered"),
            new KeyValuePair<FtxOrderStatus, string>(FtxOrderStatus.New,"new")
        };
    }
}
