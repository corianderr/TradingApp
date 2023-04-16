namespace TradingApp
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}