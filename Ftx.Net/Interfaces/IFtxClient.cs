using CryptoExchange.Net.Objects;
using Ftx.Net.Objects;
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
        Task<CallResult<FtxMarket>> GetMarketAsync(string symbol);
        CallResult<FtxMarket> GetMarket(string symbol);

        Task<CallResult<FtxOrderBook>> GetOrderBookAsync(string symbol, int depth);
        CallResult<FtxOrderBook> GetOrderBook(string symbol, int depth);


    }
}
