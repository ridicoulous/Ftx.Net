using CryptoExchange.Net.Converters;
using Ftx.Net.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Ftx.Net.Converters
{
    public class FtxOrderTypeConverter : BaseConverter<FtxOrderType>
    {
        public FtxOrderTypeConverter() : base(false)
        {
        }

        protected override List<KeyValuePair<FtxOrderType, string>> Mapping => new List<KeyValuePair<FtxOrderType, string>>()
        {
            new KeyValuePair<FtxOrderType, string>(FtxOrderType.Limit,"limit"),
            new KeyValuePair<FtxOrderType, string>(FtxOrderType.Market,"market"),
            new KeyValuePair<FtxOrderType, string>(FtxOrderType.Stop,"stop"),
            new KeyValuePair<FtxOrderType, string>(FtxOrderType.TakeProfit,"takeProfit"),
            new KeyValuePair<FtxOrderType, string>(FtxOrderType.TrailingStop,"trailingStop")
        };
    }
}
