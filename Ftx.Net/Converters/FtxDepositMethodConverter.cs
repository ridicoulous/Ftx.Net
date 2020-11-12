using CryptoExchange.Net.Converters;
using Ftx.Net.Objects;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Ftx.Net.Converters
{
    public class FtxDepositMethodConverter : BaseConverter<FtxDepositMethod>
    {
        public FtxDepositMethodConverter() : base(false)
        {
        }

        protected override List<KeyValuePair<FtxDepositMethod, string>> Mapping => new List<KeyValuePair<FtxDepositMethod, string>>()
        {
            new KeyValuePair<FtxDepositMethod, string>(FtxDepositMethod.Bep2,"bep2"),
            new KeyValuePair<FtxDepositMethod, string>(FtxDepositMethod.Erc20,"erc20"),
            new KeyValuePair<FtxDepositMethod, string>(FtxDepositMethod.Trx,"trx"),
            new KeyValuePair<FtxDepositMethod, string>(FtxDepositMethod.Sol,"sol"),
            new KeyValuePair<FtxDepositMethod, string>(FtxDepositMethod.Omni,"omni"),

        };
    }
}
