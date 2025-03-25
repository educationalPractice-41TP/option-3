namespace task4
{
    // Подписчик: Инвестор
    public class Investor
    {
        public void OnStockPriceUpdated(object sender, StockPriceEventArgs e)
        {
            Console.WriteLine($"Investor: Новая цена акций: {e.Price}");
        }
    }
}
