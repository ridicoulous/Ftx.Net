using System;
using System.Collections.Generic;
using System.Text;

namespace Ftx.Net.Objects
{
    public enum FtxCandleStickResolution
    {
        Per15Seconds = 15,
        PerMinute = 60,
        Per5minutes = 300,
        Per15minutes = 900,
        Hourly = 3600,
        Per4Hours = 14400,
        Daily = 86400
    }

    public enum FtxPositionSide
    {
        Long,
        Short
    }
    public enum FtxDepositMethod
    {
        /// <summary>
        /// For ERC20 tokens: method=erc20
        /// </summary>
        Erc20,
        /// <summary>
        /// For TRC20 tokens: method=trx
        /// </summary>
        Trx,
        /// <summary>
        /// For SPL tokens: method=sol
        /// </summary>
        Sol,
        /// <summary>
        /// For Omni tokens: method=omni
        /// </summary>
        Omni,
        /// <summary>
        /// For BEP2 tokens: method=bep2
        /// </summary>
        Bep2
    }
    public enum FtxDepositStatus
    {
        Confirmed,
        Unconfirmed,
        Cancelled
    }
    public enum FtxWithdrawalStatus
    {
        Requested,
        Processing,
        Complete,
        Cancelled
    }

    public enum FtxAirdropStatus
    {
        Complete,
        Pending
    }
    public enum FtxOrderStatus
    {
        New,
        Open,
        Closed
    }
   
    public enum FtxOrderType
    {
        Limit,
        Market,
        Stop,
        TrailingStop,
        TakeProfit
    }
    public enum FtxOrderSide
    {
        Buy,
        Sell
    }
}
