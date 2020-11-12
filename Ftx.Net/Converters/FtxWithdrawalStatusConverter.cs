using CryptoExchange.Net.Converters;
using Ftx.Net.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Ftx.Net.Converters
{
    public class FtxWithdrawalStatusConverter : BaseConverter<FtxWithdrawalStatus>
    {
        public FtxWithdrawalStatusConverter() : base(false)
        {
        }

        protected override List<KeyValuePair<FtxWithdrawalStatus, string>> Mapping => new List<KeyValuePair<FtxWithdrawalStatus, string>>()
        {
            new KeyValuePair<FtxWithdrawalStatus, string>(FtxWithdrawalStatus.Cancelled,"cancelled"),
            new KeyValuePair<FtxWithdrawalStatus, string>(FtxWithdrawalStatus.Requested,"requested"),
            new KeyValuePair<FtxWithdrawalStatus, string>(FtxWithdrawalStatus.Processing,"processing"),
            new KeyValuePair<FtxWithdrawalStatus, string>(FtxWithdrawalStatus.Complete,"complete")

        };
    }
}
