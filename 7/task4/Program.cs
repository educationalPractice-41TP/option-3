using task4;

class Program
{
    static void Main(string[] args)
    {
        StockMarket stockMarket = new StockMarket();
        Investor investor = new Investor();
        NewsPublisher newsPublisher = new NewsPublisher();
        MarketObserver marketObserver = new MarketObserver();

        // Подписываемся на события
        marketObserver.Subscribe(stockMarket, investor, newsPublisher);

        stockMarket.StockPrice = 150.75m; 
        stockMarket.StockPrice = 152.30m; 
    }
}