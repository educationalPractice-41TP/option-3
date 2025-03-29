using task3;

class Program
{
    static void Main(string[] args)
    {
        ChatRoom chatRoom = new ChatRoom();

        User user1 = new User("Алиса");
        User user2 = new User("Катя");

        chatRoom.Subscribe(user1);
        chatRoom.Subscribe(user2);

        chatRoom.SendMessage("Привет, мир!");

        chatRoom.Unsubscribe(user2);

        chatRoom.SendMessage("Как дела?");
    }
}