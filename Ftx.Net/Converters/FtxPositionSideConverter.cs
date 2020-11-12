using CryptoExchange.Net.Converters;
using Ftx.Net.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Ftx.Net.Converters
{
    public class FtxPositionSideConverter : BaseConverter<FtxPositionSide>
    {
        public FtxPositionSideConverter() : base(false)
        {
        }

        protected override List<KeyValuePair<FtxPositionSide, string>> Mapping => new List<KeyValuePair<FtxPositionSide, string>>()
        {
            new KeyValuePair<FtxPositionSide, string>(FtxPositionSide.Long,"buy"),
            new KeyValuePair<FtxPositionSide, string>(FtxPositionSide.Short,"sell")
        };
    }
}
