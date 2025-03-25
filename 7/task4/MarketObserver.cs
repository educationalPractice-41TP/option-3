namespace task4
{
    // Промежуточный класс для подписки на события
    public class MarketObserver
    {
        public void Subscribe(StockMarket market, Investor investor, NewsPublisher newsPublisher)
        {
            market.StockPriceUpdated += investor.OnStockPriceUpdated;
            market.StockPriceUpdated += newsPublisher.OnStockPriceUpdated;
        }
    }
}
