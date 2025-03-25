namespace task4
{
    // Класс-издатель
    public class StockMarket
    {
        public event EventHandler<StockPriceEventArgs> StockPriceUpdated;

        private decimal _stockPrice;

        public decimal StockPrice
        {
            get => _stockPrice;
            set
            {
                _stockPrice = value;
                OnStockPriceUpdated(new StockPriceEventArgs(_stockPrice));
            }
        }

        protected virtual void OnStockPriceUpdated(StockPriceEventArgs e)
        {
            StockPriceUpdated?.Invoke(this, e);
        }
    }
}
