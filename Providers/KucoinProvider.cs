using Binance.Net.Clients;
using Kucoin.Net.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingApp.Providers
{
    internal class KucoinProvider : ICryptoPriceProvider
    {
        private readonly KucoinClient kucoinClient;

        public KucoinProvider()
        {
            kucoinClient = new KucoinClient();
        }

        public async Task<decimal> GetPriceAsync(string symbol)
        {
            var priceData = await kucoinClient.SpotApi.ExchangeData.GetTickerAsync(symbol);
            return priceData.Data.LastPrice == null ? 0 : (decimal)priceData.Data.LastPrice;
        }
    }
}
