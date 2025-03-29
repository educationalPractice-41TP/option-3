namespace task3
{
    public class ChatRoom
    {
        private readonly List<IChatUser> _users = new List<IChatUser>();

        public void Subscribe(IChatUser user)
        {
            _users.Add(user);
            Console.WriteLine($"{user} подписался на чат.");
        }

        public void Unsubscribe(IChatUser user)
        {
            _users.Remove(user);
            Console.WriteLine($"{user} отписался от чата.");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Новое сообщение в чате: {message}");
            NotifyUsers(message);
        }

        private void NotifyUsers(string message)
        {
            foreach (var user in _users)
            {
                user.Update(message);
            }
        }
    }
}
