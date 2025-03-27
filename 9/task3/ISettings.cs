namespace task3
{
    public interface ISettings<T>
    {
        void Set(string key, T value);
        T Get(string key);
        bool ContainsKey(string key);
    }
}
