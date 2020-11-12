using CryptoExchange.Net;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.Converters;
using CryptoExchange.Net.Interfaces;
using CryptoExchange.Net.Objects;
using Ftx.Net.Interfaces;
using Ftx.Net.Objects;
using Ftx.Net.Objects.Futures;
using Ftx.Net.Objects.Markets;
using Ftx.Net.Providers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Ftx.Net
{
    public class FtxClient : RestClient, IFtxClient
    {
        private static FtxClientOptions DefaultOptions = new FtxClientOptions();
        #region Endpoints
        private const string MarketsEnpoint = "markets";
        private const string SingleMarketEnpoint = "markets/{}";
        private const string OrderBookEnpoint = "markets/{}/orderbook";
        private const string TradesEnpoint = "markets/{}/trades";
        private const string CandlesEnpoint = "markets/{}/candles";
        private const string FuturesEnpoint = "futures";



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
            var req = await SendRequest<FtxApiCallResult<List<FtxMarket>>>(GetUrl(MarketsEnpoint), HttpMethod.Get, ct);
            return new CallResult<List<FtxMarket>>(req.Data?.Data, req.Error);
        }

        public CallResult<FtxMarket> GetMarket(string symbol) => GetMarketAsync(symbol).Result;

        public async Task<CallResult<FtxMarket>> GetMarketAsync(string symbol, CancellationToken ct = default)
        {
            var req = await SendRequest<FtxApiCallResult<FtxMarket>>(GetUrl(FillPathParameter(SingleMarketEnpoint, symbol)), HttpMethod.Get, ct);
            return new CallResult<FtxMarket>(req.Data?.Data, req.Error);
        }

        public CallResult<FtxOrderBook> GetOrderBook(string symbol, int depth = 20) => GetOrderBookAsync(symbol, depth).Result;

        public async Task<CallResult<FtxOrderBook>> GetOrderBookAsync(string symbol, int depth = 20, CancellationToken ct = default)
        {
            var param = new Dictionary<string, object>();
            if (depth > 200)
            {
                depth = 200;
            }
            param.Add("depth", depth);
            var req = await SendRequest<FtxApiCallResult<FtxOrderBook>>(GetUrl(FillPathParameter(OrderBookEnpoint, symbol)), HttpMethod.Get, ct, param);
            return new CallResult<FtxOrderBook>(req.Data?.Data, req.Error);
        }

        public async Task<CallResult<List<FtxTrade>>> GetTradesAsync(string symbol, int limit = 200, DateTime? from = null, DateTime? to = null, CancellationToken ct = default)
        {
            var param = new Dictionary<string, object>();
            param.Add("limit", limit);
            param.AddOptionalParameter("start_time", JsonConvert.SerializeObject(from, new TimestampSecondsConverter()));
            param.AddOptionalParameter("end_time", JsonConvert.SerializeObject(to, new TimestampSecondsConverter()));

            var req = await SendRequest<FtxApiCallResult<List<FtxTrade>>>(GetUrl(FillPathParameter(TradesEnpoint, symbol)), HttpMethod.Get, ct, param);
            return new CallResult<List<FtxTrade>>(req.Data?.Data, req.Error);
        }

        public CallResult<List<FtxTrade>> GetTrades(string symbol, int limit = 100, DateTime? from = null, DateTime? to = null) => GetTradesAsync(symbol, limit, from, to).Result;

        public async Task<CallResult<List<FtxCandle>>> GetCandlesAsync(string symbol, FtxCandleStickResolution resolution, int? limit = null, DateTime? from = null, DateTime? to = null, CancellationToken ct = default)
        {
            var param = new Dictionary<string, object>();
            param.AddParameter("resolution", (int)resolution);
            param.AddOptionalParameter("limit", limit);
            param.AddOptionalParameter("start_time", JsonConvert.SerializeObject(from, new TimestampSecondsConverter()));
            param.AddOptionalParameter("end_time", JsonConvert.SerializeObject(to, new TimestampSecondsConverter()));

            var req = await SendRequest<FtxApiCallResult<List<FtxCandle>>>(GetUrl(FillPathParameter(CandlesEnpoint, symbol)), HttpMethod.Get, ct, param);
            return new CallResult<List<FtxCandle>>(req.Data?.Data, req.Error);
        }

        public CallResult<List<FtxCandle>> GetCandles(string symbol, FtxCandleStickResolution resolution, int? limit = null, DateTime? from = null, DateTime? to = null) => GetCandlesAsync(symbol, resolution, limit, from, to).Result;

        public async Task<CallResult<List<FtxFuture>>> GetAllFuturesAsync(CancellationToken ct = default)
        {
            var req = await SendRequest<FtxApiCallResult<List<FtxFuture>>>(GetUrl(FuturesEnpoint), HttpMethod.Get, ct);
            return new CallResult<List<FtxFuture>>(req.Data?.Data, req.Error);
        }

        public CallResult<List<FtxFuture>> GetAllFutures() => GetAllFuturesAsync().Result;

        private Dictionary<string, object> GetParametersFromObject<TObject>(TObject @object)
        {
            var serialized = JsonConvert.SerializeObject(@object);
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(serialized);
        }
    }
}
