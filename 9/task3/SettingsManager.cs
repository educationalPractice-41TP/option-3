namespace task3
{
    public class SettingsManager<T>
    {
        private SettingsStorage<T> _settingsStorage;

        public SettingsManager(SettingsStorage<T> settingsStorage)
        {
            _settingsStorage = settingsStorage;
        }

        public void ShowAllSettings()
        {
            Console.WriteLine("Текущие настройки:");
            foreach (var key in _settingsStorage.GetType()
                                                 .GetMethod("Set")
                                                 .DeclaringType
                                                 .GetField("_settings", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                                                 .GetValue(_settingsStorage) as Dictionary<string, T>)
            {
                Console.WriteLine($"{key.Key}: {key.Value}");
            }
        }

        public void RemoveSetting(string key)
        {
            if (_settingsStorage.ContainsKey(key))
            {
                _settingsStorage.Set(key, default(T)); // Удаляем, устанавливая значение по умолчанию
                Console.WriteLine($"Настройка '{key}' удалена.");
            }
            else
            {
                Console.WriteLine($"Настройки '{key}' не существует.");
            }
        }
    }
}
