using Ftx.Net.Interfaces;
using Ftx.Net.Objects;
using Ftx.Net.Objects.Orders;

namespace Ftx.Net
{
    public static partial class FtxPlaceOrderRequestFactory
    {
        public static IFtxPlaceOrderReqest CreateSimpleMarketOrder(string symbol, FtxOrderSide side, decimal size,  string clOrderId=null, bool reduceOnly = false)
        {
            return new FtxPlaceSimpleOrderRequest(symbol, side, FtxOrderType.Market, size, null,reduceOnly,clientId:clOrderId);
        }
        public static IFtxPlaceOrderReqest CreateSimpleLimitOrder(string symbol, FtxOrderSide side, decimal size, decimal price, string clOrderId = null, bool reduceOnly = false)
        {
            return new FtxPlaceSimpleOrderRequest(symbol, side, FtxOrderType.Limit, size, price, reduceOnly, clientId: clOrderId);
        }
        public static IFtxPlaceOrderReqest CreatePassiveLimitOrder(string symbol, FtxOrderSide side, decimal size, decimal price, string clOrderId = null, bool reduceOnly = false, bool ioc=false)
        {
            return new FtxPlaceSimpleOrderRequest(symbol:symbol,
                                                  side:side,
                                                  type: FtxOrderType.Limit,
                                                  size:size,
                                                  price:price,
                                                  reduceOnly: reduceOnly,
                                                  clientId: clOrderId,
                                                  postOnly: true,
                                                  ioc:ioc);
        }
        public static IFtxPlaceOrderReqest CreateTakeProfitOrder(string symbol, FtxOrderSide side, decimal size, decimal triggerPrice, decimal? limitPrice=null, string clOrderId = null, bool reduceOnly = false)
        {
            return new FtxPlaceStopOrTakeOrderRequest(symbol, false, side, size, triggerPrice, limitPrice, reduceOnly, clOrderId);
        }
        public static IFtxPlaceOrderReqest CreateStopOrder(string symbol, FtxOrderSide side, decimal size, decimal triggerPrice,  decimal? limitPrice = null, string clOrderId = null, bool reduceOnly = false)
        {
            return new FtxPlaceStopOrTakeOrderRequest(symbol, true, side, size, triggerPrice, limitPrice, reduceOnly, clOrderId);
        }
        public static IFtxPlaceOrderReqest CreateTrailingStopOrder(string symbol, FtxOrderSide side, decimal size, decimal trailValue,  string clOrderId = null, bool reduceOnly = false)
        {
            return new FtxPlaceTrailingOrderRequest(symbol,side,size,trailValue,reduceOnly,clOrderId);
        }
    }
}
