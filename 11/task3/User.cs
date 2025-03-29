namespace task3
{
    public class User : IChatUser
    {
        public string Name { get; }

        public User(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"Пользователь {Name} получил сообщение: {message}");
        }
    }
}
