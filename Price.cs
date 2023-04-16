using Binance.Net.Clients;
using TradingApp.Providers;

namespace TradingApp
{
    public partial class Price : Form
    {
        private readonly BinanceProvider binanceProvider;
        private readonly KucoinProvider kucoinProvider;
        private readonly BybitProvider bybitProvider;
        public Price()
        {
            InitializeComponent();
            binanceProvider = new BinanceProvider();
            kucoinProvider = new KucoinProvider();
            bybitProvider = new BybitProvider();
        }

        private async void TimerTick(object? sender, EventArgs e)
        {
            await UpdatePrices();
        }

        private async Task UpdatePrices()
        {
            binanceBox.Text = $"{await binanceProvider.GetPriceAsync("BTCUSDT"):n}";
            kucoinBox.Text = $"{await kucoinProvider.GetPriceAsync("BTC-USDT"):n}";
            bybitBox.Text = $"{await bybitProvider.GetPriceAsync("BTCUSDT"):n}";
        }

        private async void PriceLoad(object sender, EventArgs e)
        {
            await UpdatePrices();
            timer1.Interval = 5000;
            timer1.Tick += TimerTick;
            timer1.Start();
        }
    }
}