using CryptoExchange.Net.Objects;
using Ftx.Net.Objects;
using Ftx.Net.Objects.Account;
using Ftx.Net.Objects.Futures;
using Ftx.Net.Objects.Markets;
using Ftx.Net.Objects.Orders;
using Ftx.Net.Objects.SubAccounts;
using Ftx.Net.Objects.Wallet;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ftx.Net.Interfaces
{
    public interface IFtxClient
    {
        /// <summary>
        /// This section covers all types of markets on FTX: spot, perpetual futures, expiring futures, and MOVE contracts. Examples for each type are BTC/USD, BTC-PERP, BTC-0626, and BTC-MOVE-1005. For futures that expired in 2019, prepend a 2019 to the date, like so: BTC-20190628 or BTC-MOVE-20190923
        /// </summary>
        /// <returns></returns>
        Task<CallResult<List<FtxMarket>>> GetAllMarketsAsync(CancellationToken cancellationToken);
        /// <summary>
        /// This section covers all types of markets on FTX: spot, perpetual futures, expiring futures, and MOVE contracts. Examples for each type are BTC/USD, BTC-PERP, BTC-0626, and BTC-MOVE-1005. For futures that expired in 2019, prepend a 2019 to the date, like so: BTC-20190628 or BTC-MOVE-20190923
        /// </summary>
        /// <returns></returns>
        CallResult<List<FtxMarket>> GetAllMarkets();
        /// <summary>
        /// see get all markets
        /// </summary>
        /// <param name="marketName"></param>
        /// <returns></returns>
        Task<CallResult<FtxMarket>> GetMarketAsync(string symbol, CancellationToken ct = default);
        CallResult<FtxMarket> GetMarket(string symbol);

        Task<CallResult<FtxOrderBook>> GetOrderBookAsync(string symbol, int depth = 200, CancellationToken ct = default);
        CallResult<FtxOrderBook> GetOrderBook(string symbol, int depth);


        Task<CallResult<List<FtxTrade>>> GetTradesAsync(string symbol, int limit = 200, DateTime? from = null, DateTime? to = null, CancellationToken ct = default);
        CallResult<List<FtxTrade>> GetTrades(string symbol, int limit = 200, DateTime? from = null, DateTime? to = null);

        Task<CallResult<List<FtxCandle>>> GetCandlesAsync(string symbol, FtxCandleStickResolution resolution, int? limit = null, DateTime? from = null, DateTime? to = null, CancellationToken ct = default);
        CallResult<List<FtxCandle>> GetCandles(string symbol, FtxCandleStickResolution resolution, int? limit = null, DateTime? from = null, DateTime? to = null);



        Task<CallResult<List<FtxSubAccount>>> GetSubAccountsAsync(CancellationToken ct = default);
        CallResult<List<FtxSubAccount>> GetSubAccounts();

        Task<CallResult<FtxSubAccount>> CreateSubAccountAsync(string nickName, CancellationToken ct = default);
        CallResult<FtxSubAccount> CreateSubAccount(string nickName);

        Task<CallResult<FtxSubAccount>> EditSubAccountAsync(string oldNickName, string newNickname, CancellationToken ct = default);
        CallResult<FtxSubAccount> EditSubAccount(string oldNickName, string newNickname);

        Task<CallResult<bool>> DeleteSubAccountAsync(string nickName, CancellationToken ct = default);
        CallResult<bool> DeleteSubAccount(string nickName);

        Task<CallResult<List<FtxSubAccountBalance>>> GetSubAccountBalancesAsync(string nickName, CancellationToken ct = default);
        CallResult<List<FtxSubAccountBalance>> GetSubAccountBalances(string nickName);

        Task<CallResult<List<FtxTransferResult>>> TransferBetweenAccountAsync(FtxTransferCoinRequest request, CancellationToken ct = default);
        CallResult<List<FtxTransferResult>> TransferBetweenAccount(FtxTransferCoinRequest request);

        Task<CallResult<List<FtxFuture>>> GetAllFuturesAsync(CancellationToken ct = default);
        CallResult<List<FtxFuture>> GetAllFutures();

        Task<CallResult<FtxFuture>> GetFutureAsync(string futureName, CancellationToken ct = default);
        CallResult<FtxFuture> GetFuture(string futureName);

        Task<CallResult<FtxFutureStats>> GetFutureStatsAsync(string futureName, CancellationToken ct = default);
        CallResult<FtxFutureStats> GetFutureStats(string futureName);

        Task<CallResult<List<FtxFundingRate>>> GetAllFundingRatesAsync(CancellationToken ct = default);
        CallResult<List<FtxFundingRate>> GetAllFundingRates();

        Task<CallResult<Dictionary<string, decimal>>> GetAllIndexWeightsAsync(CancellationToken ct = default);
        CallResult<Dictionary<string, decimal>> GetAllIndexWeights();

        Task<CallResult<List<FtxFuture>>> GetAllExpiredFuturesAsync(CancellationToken ct = default);
        CallResult<List<FtxFuture>> GetAllExpiredFutures();

        Task<CallResult<List<FtxCandle>>> GetFutureHistoricalIndexAsync(string symbol, FtxCandleStickResolution resolution, int? limit = null, DateTime? from = null, DateTime? to = null, CancellationToken ct = default);
        CallResult<List<FtxCandle>> GetFutureHistoricalIndex(string symbol, FtxCandleStickResolution resolution, int? limit = null, DateTime? from = null, DateTime? to = null);

        Task<CallResult<FtxAccountInfo>> GetAxccountInfoAsync(CancellationToken ct = default);
        CallResult<FtxAccountInfo> GetAxccountInfo();

        Task<CallResult<List<FtxPosition>>> GetAccountPositionsAsync(bool? showAvgPrice = null, CancellationToken ct = default);
        CallResult<List<FtxPosition>> GetAccountPositions(bool? showAvgPrice = null);

        Task<CallResult<bool>> ChangeAccountLeverageAsync(int leverage, CancellationToken ct = default);
        CallResult<bool> ChangeAccountLeverage(int leverage);

        Task<CallResult<List<FtxCoinInfo>>> GetWalletCoinsInfoAsync(CancellationToken ct = default);
        CallResult<List<FtxCoinInfo>> GetWalletCoinsInfo();

        Task<CallResult<List<FtxCoinBalance>>> GetCoinBalancesAsync(CancellationToken ct = default);
        CallResult<List<FtxCoinBalance>> GetCoinBalances();

        Task<CallResult<Dictionary<string, List<FtxCoinBalance>>>> GetCoinBalancesForAllAccountsAsync(CancellationToken ct = default);
        CallResult<Dictionary<string, List<FtxCoinBalance>>> GetCoinBalancesForAllAccounts();

        Task<CallResult<FtxGenerateAddressResult>> GenerateDepositAddressAsync(FtxDepositMethod depositMethod, CancellationToken ct = default);
        CallResult<FtxGenerateAddressResult> GenerateDepositAddress(FtxDepositMethod depositMethod);


        Task<CallResult<List<FtxDeposit>>> GetDepositHistoryAsync(int? limit = null, DateTime? from = null, DateTime? to = null, CancellationToken ct = default);
        CallResult<List<FtxDeposit>> GetDepositHistory(int? limit = null, DateTime? from = null, DateTime? to = null);
        
        Task<CallResult<List<FtxWithdrawal>>> GetWithdrawalHistoryAsync(int? limit = null, DateTime? from = null, DateTime? to = null, CancellationToken ct = default);
        CallResult<List<FtxWithdrawal>> GetWithdrawalHistory(int? limit = null, DateTime? from = null, DateTime? to = null);


        Task<CallResult<FtxWithdrawal>> RequestWithdrawalAsync(FtxWithdrawalRequest request, CancellationToken ct = default);
        CallResult<FtxWithdrawal> RequestWithdrawal(FtxWithdrawalRequest request);

        Task<CallResult<List<FtxAirdrop>>> GetAirdropsAsync(CancellationToken ct = default);
        CallResult<List<FtxAirdrop>> GetAirdrops();

        Task<CallResult<List<FtxSavedAddress>>> GetSavedAddressessAsync(CancellationToken ct = default);
        CallResult<List<FtxSavedAddress>> GetSavedAddressess(CancellationToken ct = default);

        Task<CallResult<FtxSavedAddress>> CreateSavedAddressAsync(FtxSaveAddressRequest request, CancellationToken ct = default);
        CallResult<FtxSavedAddress> CreateSavedAddress(FtxSaveAddressRequest request);

        Task<CallResult<string>> DeleteSavedAddressAsync(int addressId, CancellationToken ct = default);
        CallResult<string> DeleteSavedAddress(int addressId);

        Task<CallResult<List<FtxOrder>>> GetOpenOrdersAsync(string symbol=null, CancellationToken ct = default);
        CallResult<List<FtxOrder>> GetOpenOrders(string symbol=null);

        Task<CallResult<List<FtxOrder>>> GetOrdersHistoryAsync(string symbol = null, int? limit = null, DateTime? from = null, DateTime? to = null, CancellationToken ct = default);
        CallResult<List<FtxOrder>> GetOrdersHistory(string symbol = null, int? limit = null, DateTime? from = null, DateTime? to = null);


        Task<CallResult<List<FtxOrder>>> GetOpenConditionalOrdersAsync(string symbol = null, FtxOrderType? type=null, CancellationToken ct = default);
        CallResult<List<FtxOrder>> GetOpenConditionalOrders(string symbol = null, FtxOrderType? type = null);



        /*
         
         -------------======== SUBACCOUNTS =========--------------
         -------------======== Markets =========--------------

         -------------======== FUTURES =========--------------         
     
        -------------======== ACCOUNT =========--------------
    
        -------------======== WALLET =========--------------
     

        -------------======== ORDERS =========--------------
        Get open orders
        Get order history
        Get open trigger orders
        Get trigger order history
        Place order
        Place trigger order
        Edit order
        Edit order by clOrd id
        Edit trigger order
        Get order status
        Get order status by clOrd id
        Cancel Order
        Cancel Order by clOrd id
        Cancel open trigger order 
        Cancel all

        -------------======== Convert =========--------------

        Request quote
        Get quote status
        Accept quote

        -------------======== Fills =========--------------
        Get list of user's fills

        -------------======== Funding payments =========--------------

        Get list of user's Funding payments
        
        -------------======== Leveraged tokens =========--------------
        Get list
        Get token info
        Get leveraged token balances
        List leveraged token creation requests
        Request leveraged token creation
        List leveraged token redemption requests
        Request leveraged token redemption

        -------------======== Options =========--------------
        List quote requests
        Your quote requests
        Create quote request
        Cancel quote request
        Get quotes for your quote request
        Create quote
        Get my quotes
        Cancel quote
        Accept options quote
        Get account options info
        Get options positions
        Get public options trades
        Get options fills
        Get 24h option volume
        Get option open interest
        Get historical option open interest

        -------------======== SRM Staking =========--------------

        Get stakes
        Unstake request
        Get stake balances
        Unstake request
        Cancel unstake request
        Get staking rewards
        Stake request
         */



    }
}
