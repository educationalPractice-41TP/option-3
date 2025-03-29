namespace task2
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата {amount} с помощью кредитной карты.");
        }
    }

    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата {amount} с помощью PayPal.");
        }
    }

    public class BitcoinPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата {amount} с помощью Bitcoin.");
        }
    }
}
