using task1;

public class Program
{
    public static void Main()
    {
        Cache cache = new Cache();

        // Добавляем данные в кэш
        cache.AddToCache(1, new DataEntity(1, "Entity One"));
        cache.AddToCache(2, new DataEntity(2, "Entity Two"));

        // Отображаем содержимое кэша
        cache.DisplayCache();

        // Получаем данные из кэша
        DataEntity entity = cache.GetFromCache(1);
        Console.WriteLine("Получено из кэша: " + entity);

        // Удаляем данные из кэша
        cache.RemoveFromCache(1);
        cache.DisplayCache();
    }
}