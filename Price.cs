namespace TradingApp
{
    public partial class Price : Form
    {
        private int count = 0;
        public Price()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Tick += Timer_Tick;
            timer1.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            binanceBox.Text = "Update" + ++count;
            kucoinBox.Text = "Update" + count;
            bybitBox.Text = "Update" + count;
        }

        private void Price_Load(object sender, EventArgs e)
        {

        }
    }
}