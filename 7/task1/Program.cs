using task1;

class Program
{
    static void Main(string[] args)
    {
        EmailNotifier emailNotifier = new EmailNotifier();
        SmsNotifier smsNotifier = new SmsNotifier();
        // Создание делегата 
        NotificationHandler notificationHandler;

        notificationHandler = emailNotifier.SendEmail;
        notificationHandler += smsNotifier.SendSms;
        notificationHandler("Уведомление: Ваша подписка активирована!");
        // Удаление метода SMS и вызов делегата снова
        notificationHandler -= smsNotifier.SendSms;
        notificationHandler("Уведомление: Ваша учетная запись обновлена!");
    }
}