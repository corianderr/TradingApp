using Kucoin.Net.Clients;

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
