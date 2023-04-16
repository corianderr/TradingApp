using Bybit.Net.Clients;

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
