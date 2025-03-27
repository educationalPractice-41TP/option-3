using System.Collections;

namespace task1
{
public class Cache
{
    private Hashtable _cache;

    public Cache()
    {
        _cache = new Hashtable();
    }

    public void AddToCache(int key, DataEntity value)
    {
        if (!_cache.ContainsKey(key))
        {
            _cache.Add(key, value);
            Console.WriteLine($"Добалвено в кэш: {value}");
        }
        else
        {
            Console.WriteLine("Ключ уже существует.");
        }
    }

    public DataEntity GetFromCache(int key)
    {
        if (_cache.ContainsKey(key))
        {
            return (DataEntity)_cache[key];
        }
        else
        {
            Console.WriteLine("Ключ не найден.");
            return null;
        }
    }

    public void RemoveFromCache(int key)
    {
        if (_cache.ContainsKey(key))
        {
            _cache.Remove(key);
            Console.WriteLine($"Удален из кэша: Ключ {key}");
        }
        else
        {
            Console.WriteLine("Ключ не найден.");
        }
    }

    public void DisplayCache()
    {
        Console.WriteLine("Кэш:");
        foreach (DictionaryEntry entry in _cache)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
}
