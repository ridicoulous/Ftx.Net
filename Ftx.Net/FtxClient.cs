using CryptoExchange.Net;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Objects;
using Ftx.Net.Interfaces;
using Ftx.Net.Objects;
using Ftx.Net.Providers;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Ftx.Net
{
    public class FtxClient : RestClient, IFtxClient
    {
        private static FtxClientOptions DefaultOptions = new FtxClientOptions();
        #region Endpoints
        private const string MarketsEnpoint = "markets";
        #endregion
        public FtxClient() : base(DefaultOptions, null)
        {

        }
        public FtxClient(FtxClientOptions exchangeOptions, FtxAuthenticationProvider authenticationProvider) : base(exchangeOptions, authenticationProvider)
        {
        }
        private Uri GetUrl(string endpoint)
        {
            return new Uri(BaseAddress + endpoint);
        }

        public CallResult<List<FtxMarket>> GetAllMarkets() => GetAllMarketsAsync().Result;

        public async Task<CallResult<List<FtxMarket>>> GetAllMarketsAsync(CancellationToken ct = default)
        {
            var result = await SendRequest<FtxApiCallResult<List<FtxMarket>>>(GetUrl(MarketsEnpoint), HttpMethod.Get, ct);
            return new CallResult<List<FtxMarket>>(result.Data.IsSuccess ? result.Data.Data : null, new ServerError("error", result.Data));
        }



        public CallResult<FtxMarket> GetMarket(string symbol)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<FtxMarket>> GetMarketAsync(string symbol)
        {
            throw new NotImplementedException();
        }

        public CallResult<FtxOrderBook> GetOrderBook(string symbol, int depth)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<FtxOrderBook>> GetOrderBookAsync(string symbol, int depth)
        {
            throw new NotImplementedException();
        }


    }
}
