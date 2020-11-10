using CryptoExchange.Net.Objects;
using CryptoExchange.Net.OrderBook;
using CryptoExchange.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ftx.Net
{
    public class FtxSymbolOrderBook : SymbolOrderBook
    {
        private readonly FtxSocketClient _socket;
        public FtxSymbolOrderBook(string symbol, OrderBookOptions options) : base(symbol, options)
        {
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        protected override Task<CallResult<bool>> DoResync()
        {
            throw new NotImplementedException();
        }

        protected override Task<CallResult<UpdateSubscription>> DoStart()
        {
            throw new NotImplementedException();
        }
    }
}
