namespace task3
{
    public class SettingsStorage<T> : ISettings<T>
    {
        private Dictionary<string, T> _settings;

        public SettingsStorage()
        {
            _settings = new Dictionary<string, T>();
        }

        public void Set(string key, T value)
        {
            _settings[key] = value;
        }

        public T Get(string key)
        {
            if (_settings.TryGetValue(key, out T value))
            {
                return value;
            }
            throw new KeyNotFoundException($"Настройка с ключом '{key}' не найдена.");
        }

        public bool ContainsKey(string key)
        {
            return _settings.ContainsKey(key);
        }
    }
}
