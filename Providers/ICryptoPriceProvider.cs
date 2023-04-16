namespace TradingApp
{
    internal interface ICryptoPriceProvider
    {
        Task<decimal> GetPriceAsync(string symbol);
    }
}
