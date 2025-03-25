namespace task1
{
    public delegate void NotificationHandler(string message);

    public class EmailNotifier
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email отправлено: {message}");
        }
    }

    public class SmsNotifier
    {
        public void SendSms(string message)
        {
            Console.WriteLine($"SMS отправлено: {message}");
        }
    }
}
