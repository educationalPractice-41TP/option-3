using task1;

class Program
{
    static void Main(string[] args)
    {
        CacheManager cache = CacheManager.Instance;

        var user1 = new User { Name = "Иван", Age = 11 };
        var user2 = new User { Name = "Пашок", Age = 12 };
        cache.AddToCache("user1", user1);
        cache.AddToCache("user2", user2);

        var userFromCache1 = cache.GetFromCache<User>("user1");
        var userFromCache2 = cache.GetFromCache<User>("user2"); 

        Console.WriteLine($"Имя: {userFromCache1.Name}, Возраст: {userFromCache1.Age}");
        Console.WriteLine($"Имя: {userFromCache2.Name}, Возраст: {userFromCache2.Age}");
    }
}