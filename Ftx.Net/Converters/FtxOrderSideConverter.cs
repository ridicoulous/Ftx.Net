using CryptoExchange.Net.Converters;
using Ftx.Net.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Ftx.Net.Converters
{
    public class FtxOrderSideConverter : BaseConverter<FtxOrderSide>
    {
        public FtxOrderSideConverter() : base(false)
        {
        }

        protected override List<KeyValuePair<FtxOrderSide, string>> Mapping => new List<KeyValuePair<FtxOrderSide, string>>()
        {
            new KeyValuePair<FtxOrderSide, string>(FtxOrderSide.Buy,"buy"),
            new KeyValuePair<FtxOrderSide, string>(FtxOrderSide.Sell,"sell")

        };
    }
}
