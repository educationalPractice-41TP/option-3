namespace task1
{
    public class CacheManager
    {
        private static readonly CacheManager _instance = new CacheManager();
        private readonly Dictionary<string, object> _cache;

        private CacheManager()
        {
            _cache = new Dictionary<string, object>();
        }

        public static CacheManager Instance
        {
            get { return _instance; }
        }

        public void AddToCache(string key, object value)
        {
            if (!_cache.ContainsKey(key))
            {
                _cache[key] = value;
            }
        }

        public T GetFromCache<T>(string key)
        {
            _cache.TryGetValue(key, out var value);
            return (T)value;
        }
    }
}
