using Bybit.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingApp.Providers
{
    internal class BybitProvider : ICryptoPriceProvider
    {
        private readonly BybitClient bybitClient;

        public BybitProvider()
        {
            bybitClient = new BybitClient();
        }

        public async Task<decimal> GetPriceAsync(string symbol)
        {
            var priceData = await bybitClient.SpotApiV1.ExchangeData.GetPriceAsync(symbol);
            return priceData.Data.Price;
        }
    }
}
