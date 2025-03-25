namespace task4
{
    // Аргументы события
    public class StockPriceEventArgs : EventArgs
    {
        public decimal Price { get; }

        public StockPriceEventArgs(decimal price)
        {
            Price = price;
        }
    }
}
