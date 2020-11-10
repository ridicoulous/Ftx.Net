using CryptoExchange.Net.Authentication;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text;

namespace Ftx.Net.Objects
{
    public class FtxApiCredentials : ApiCredentials
    {
        public readonly string SubAccount; 
        public FtxApiCredentials(string key, string secret, string subAccount=null) : base(key, secret)
        {
            SubAccount = subAccount;
        }       
    }
}
