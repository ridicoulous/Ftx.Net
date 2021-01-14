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
using Ftx.Net.Objects.Account;
using Ftx.Net.Objects.FilterRequests;
using Ftx.Net.Objects.Orders;
using Ftx.Net.Objects.SubAccounts;
using Ftx.Net.Objects.Wallet;

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
        private const string AccountEndpoint = "account";



        #endregion
        public FtxClient() : base(nameof(FtxClient),DefaultOptions, null)
        {

        }
        public FtxClient(FtxClientOptions exchangeOptions, FtxAuthenticationProvider authenticationProvider) : base(nameof(FtxClient), exchangeOptions, authenticationProvider)
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
        public Task<CallResult<List<FtxSubAccount>>> GetSubAccountsAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxSubAccount>> GetSubAccounts()
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<FtxSubAccount>> CreateSubAccountAsync(string nickName, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<FtxSubAccount> CreateSubAccount(string nickName)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<FtxSubAccount>> EditSubAccountAsync(string oldNickName, string newNickname, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<FtxSubAccount> EditSubAccount(string oldNickName, string newNickname)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<bool>> DeleteSubAccountAsync(string nickName, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<bool> DeleteSubAccount(string nickName)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxSubAccountBalance>>> GetSubAccountBalancesAsync(string nickName, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxSubAccountBalance>> GetSubAccountBalances(string nickName)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxTransferResult>>> TransferBetweenAccountAsync(FtxTransferCoinRequest request, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxTransferResult>> TransferBetweenAccount(FtxTransferCoinRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<CallResult<List<FtxFuture>>> GetAllFuturesAsync(CancellationToken ct = default)
        {
            var req = await SendRequest<FtxApiCallResult<List<FtxFuture>>>(GetUrl(FuturesEnpoint), HttpMethod.Get, ct);
            return new CallResult<List<FtxFuture>>(req.Data?.Data, req.Error);
        }

        public CallResult<List<FtxFuture>> GetAllFutures() => GetAllFuturesAsync().Result;
        public Task<CallResult<FtxFuture>> GetFutureAsync(string futureName, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<FtxFuture> GetFuture(string futureName)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<FtxFutureStats>> GetFutureStatsAsync(string futureName, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<FtxFutureStats> GetFutureStats(string futureName)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxFundingRate>>> GetAllFundingRatesAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxFundingRate>> GetAllFundingRates()
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<Dictionary<string, decimal>>> GetAllIndexWeightsAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<Dictionary<string, decimal>> GetAllIndexWeights()
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxFuture>>> GetAllExpiredFuturesAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxFuture>> GetAllExpiredFutures()
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxCandle>>> GetFutureHistoricalIndexAsync(string symbol, FtxCandleStickResolution resolution, int? limit = null,
            DateTime? @from = null, DateTime? to = null, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxCandle>> GetFutureHistoricalIndex(string symbol, FtxCandleStickResolution resolution, int? limit = null,
            DateTime? @from = null, DateTime? to = null)
        {
            throw new NotImplementedException();
        }

        public async Task<CallResult<FtxAccountInfo>> GetAccountInfoAsync(CancellationToken ct = default)
        {
            var param = new Dictionary<string, object>();
            var req = await SendRequest<FtxApiCallResult<FtxAccountInfo>>(GetUrl(FillPathParameter(AccountEndpoint)), HttpMethod.Get, ct, param, true);
            return new CallResult<FtxAccountInfo>(req.Data?.Data, req.Error);
        }

        public CallResult<FtxAccountInfo> GetAccountInfo() => GetAccountInfoAsync().Result;

        public Task<CallResult<List<FtxPosition>>> GetAccountPositionsAsync(bool? showAvgPrice = null, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxPosition>> GetAccountPositions(bool? showAvgPrice = null)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<bool>> ChangeAccountLeverageAsync(int leverage, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<bool> ChangeAccountLeverage(int leverage)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxCoinInfo>>> GetWalletCoinsInfoAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxCoinInfo>> GetWalletCoinsInfo()
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxCoinBalance>>> GetCoinBalancesAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxCoinBalance>> GetCoinBalances()
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<Dictionary<string, List<FtxCoinBalance>>>> GetCoinBalancesForAllAccountsAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<Dictionary<string, List<FtxCoinBalance>>> GetCoinBalancesForAllAccounts()
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<FtxGenerateAddressResult>> GenerateDepositAddressAsync(FtxDepositMethod depositMethod, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<FtxGenerateAddressResult> GenerateDepositAddress(FtxDepositMethod depositMethod)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxDeposit>>> GetDepositHistoryAsync(int? limit = null, DateTime? @from = null, DateTime? to = null,
            CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxDeposit>> GetDepositHistory(int? limit = null, DateTime? @from = null, DateTime? to = null)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxWithdrawal>>> GetWithdrawalHistoryAsync(int? limit = null, DateTime? @from = null, DateTime? to = null,
            CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxWithdrawal>> GetWithdrawalHistory(int? limit = null, DateTime? @from = null, DateTime? to = null)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<FtxWithdrawal>> RequestWithdrawalAsync(FtxWithdrawalRequest request, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<FtxWithdrawal> RequestWithdrawal(FtxWithdrawalRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxAirdrop>>> GetAirdropsAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxAirdrop>> GetAirdrops()
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxSavedAddress>>> GetSavedAddressessAsync(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxSavedAddress>> GetSavedAddressess(CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<FtxSavedAddress>> CreateSavedAddressAsync(FtxSaveAddressRequest request, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<FtxSavedAddress> CreateSavedAddress(FtxSaveAddressRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<string>> DeleteSavedAddressAsync(int addressId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<string> DeleteSavedAddress(int addressId)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxOrder>>> GetOpenOrdersAsync(string symbol = null, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxOrder>> GetOpenOrders(string symbol = null)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxOrder>>> GetOrdersHistoryAsync(string symbol = null, int? limit = null, DateTime? @from = null, DateTime? to = null,
            CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxOrder>> GetOrdersHistory(string symbol = null, int? limit = null, DateTime? @from = null, DateTime? to = null)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxOrder>>> GetOpenConditionalOrdersAsync(string symbol = null, FtxOrderType? type = null, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxOrder>> GetOpenConditionalOrders(string symbol = null, FtxOrderType? type = null)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxConditionalOrerTrigger>>> GetOpenConditionalOrderTriggerssAsync(long orderId, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxConditionalOrerTrigger>> GetOpenConditionalOrderTriggerss(long orderId)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<List<FtxOrder>>> GetConditionalOrderTriggersHistoryAsync(FtxFilterRequest request, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<List<FtxOrder>> GetConditionalOrderTriggersHistory(FtxFilterRequest request, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public Task<CallResult<FtxOrder>> UpdateOrderAsync(FtxUpdateOrderRequest request, CancellationToken ct = default)
        {
            throw new NotImplementedException();
        }

        public CallResult<FtxOrder> UpdateOrder(FtxUpdateOrderRequest request)
        {
            throw new NotImplementedException();
        }

        private Dictionary<string, object> GetParametersFromObject<TObject>(TObject @object)
        {
            var serialized = JsonConvert.SerializeObject(@object);
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(serialized);
        }
    }
}
