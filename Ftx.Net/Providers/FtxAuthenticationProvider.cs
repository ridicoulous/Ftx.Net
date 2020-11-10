using CryptoExchange.Net;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Objects;
using Ftx.Net.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;

namespace Ftx.Net.Providers
{
    public class FtxAuthenticationProvider : AuthenticationProvider
    {
        private readonly string SubAccount;
        public FtxAuthenticationProvider(FtxApiCredentials credentials) : base(credentials)
        {
            SubAccount = credentials.SubAccount;
        }
        private readonly HMACSHA256 encryptor;
        private readonly DateTime UnixEpox = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        private static readonly object requestTsLock = new object();
        private long lastRequestTimestamp;
        internal string RequestTimestamp
        {
            get
            {
                lock (requestTsLock)
                {
                    var ts = (long)Math.Round((DateTime.UtcNow - UnixEpox).TotalMilliseconds);
                    if (ts == lastRequestTimestamp)
                        ts += 1;

                    lastRequestTimestamp = ts;
                    return lastRequestTimestamp.ToString(CultureInfo.InvariantCulture);
                }
            }
        }
        public FtxAuthenticationProvider(ApiCredentials credentials, TimeSpan? requestLifeTime = null) : base(credentials)
        {
           encryptor = new HMACSHA256(Encoding.ASCII.GetBytes(credentials.Secret.GetString()));
        }
        public override Dictionary<string, string> AddAuthenticationToHeaders(string uri, HttpMethod method, Dictionary<string, object> parameters, bool signed, PostParameters postParameters, ArrayParametersSerialization arrayParametersSerialization)
        {
            string ts = RequestTimestamp;
            if (!signed)
                return new Dictionary<string, string>();
            var result = new Dictionary<string, string>();
            result.Add("FTX-KEY", Credentials.Key.GetString());
            result.Add("FTX-TS", ts);
            string additionalData = String.Empty;
            if (parameters != null && parameters.Any() && method != HttpMethod.Delete && method != HttpMethod.Get)
            {
                additionalData = JsonConvert.SerializeObject(parameters.OrderBy(p => p.Key).ToDictionary(p => p.Key, p => p.Value));
            }
            var dataToSign = CreateAuthPayload(method, uri.Split(new[] { ".com" }, StringSplitOptions.None)[1], ts, additionalData);
            var signedData = Sign(dataToSign);
            result.Add("FTX-SIGN", signedData);
            result.AddOptionalParameter("FTX-SUBACCOUNT", SubAccount);
            return result;
        }
        public string ByteArrayToString(byte[] ba)
        {
            var hex = new StringBuilder(ba.Length * 2);
            foreach (var b in ba)
                hex.AppendFormat("{0:X2}", b);
            return hex.ToString();
        }
        public override string Sign(string toSign)
        {
            return ByteArrayToString(encryptor.ComputeHash(Encoding.UTF8.GetBytes(toSign)));
        }
        /// <summary>
        /// {ts}{prepared.method}{prepared.path_url}'
        /// </summary>
        /// <param name="methodAndUrl">GET/api/v1/orderBookL2 (for websocketauth - GET/realtime)</param>
        /// <param name="additionalData">optinal request data</param>
        /// <returns></returns>
        public string CreateAuthPayload(HttpMethod method, string requestUrl, string requestTimestamp, string additionalData = "")
        {
            return $"{requestTimestamp}{method}{requestUrl}{additionalData}";
        }
        /*
         For authenticated requests, the following headers should be sent with the request:

FTX-KEY: Your API key
FTX-TS: Number of milliseconds since Unix epoch
FTX-SIGN: SHA256 HMAC of the following four strings, using your API secret, as a hex string:
Request timestamp (e.g. 1528394229375)
HTTP method in uppercase (e.g. GET or POST)
Request path, including leading slash and any URL parameters but not including the hostname (e.g. /account)
(POST only) Request body (JSON-encoded)
FTX-SUBACCOUNT (optional): URI-encoded name of the subaccount to use. Omit if not using subaccounts.*/
    }
}
