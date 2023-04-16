using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingApp
{
    internal interface ICryptoPriceProvider
    {
        Task<decimal> GetPrice(string symbol);
    }
}
