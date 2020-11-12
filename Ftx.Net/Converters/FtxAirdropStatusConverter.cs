using CryptoExchange.Net.Converters;
using Ftx.Net.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Ftx.Net.Converters
{
    public class FtxAirdropStatusConverter : BaseConverter<FtxAirdropStatus>
    {
        public FtxAirdropStatusConverter() : base(false)
        {
        }

        protected override List<KeyValuePair<FtxAirdropStatus, string>> Mapping => new List<KeyValuePair<FtxAirdropStatus, string>>()
        {
            new KeyValuePair<FtxAirdropStatus, string>(FtxAirdropStatus.Pending,"pending"),
            new KeyValuePair<FtxAirdropStatus, string>(FtxAirdropStatus.Complete,"complete")
        };
    }
}
