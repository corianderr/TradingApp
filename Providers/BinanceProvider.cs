using Binance.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingApp.Providers
{
    internal class BinanceProvider : ICryptoPriceProvider
    {
        private readonly BinanceClient binanceClient;

        public BinanceProvider()
        {
            binanceClient = new BinanceClient();
        }

        public async Task<decimal> GetPriceAsync(string symbol)
        {
            var priceData = await binanceClient.SpotApi.ExchangeData.GetPriceAsync(symbol);
            return priceData.Data.Price;
        }
    }
}
