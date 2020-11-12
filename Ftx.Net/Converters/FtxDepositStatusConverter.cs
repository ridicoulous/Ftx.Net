using CryptoExchange.Net.Converters;
using Ftx.Net.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Ftx.Net.Converters
{
    public class FtxDepositStatusConverter : BaseConverter<FtxDepositStatus>
    {
        public FtxDepositStatusConverter() : base(false)
        {
        }

        protected override List<KeyValuePair<FtxDepositStatus, string>> Mapping => new List<KeyValuePair<FtxDepositStatus, string>>()
        {
            new KeyValuePair<FtxDepositStatus, string>(FtxDepositStatus.Cancelled,"cancelled"),
            new KeyValuePair<FtxDepositStatus, string>(FtxDepositStatus.Unconfirmed,"unconfirmed"),
            new KeyValuePair<FtxDepositStatus, string>(FtxDepositStatus.Confirmed,"confirmed")
        };
    }
}
