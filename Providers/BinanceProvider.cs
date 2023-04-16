using Binance.Net.Clients;

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
