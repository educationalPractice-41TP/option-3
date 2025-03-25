namespace task4
{
    // Подписчик: Издатель новостей
    public class NewsPublisher
    {
        public void OnStockPriceUpdated(object sender, StockPriceEventArgs e)
        {
            Console.WriteLine($"NewsPublisher: Обновление! Цена акций: {e.Price}");
        }
    }
}
