using task2;

class Program
{
    static void Main(string[] args)
    {
        PaymentProcessor paymentProcessor = new PaymentProcessor();

        paymentProcessor.SetPaymentStrategy(new CreditCardPayment());
        paymentProcessor.ProcessPayment(100.00m);

        paymentProcessor.SetPaymentStrategy(new PayPalPayment());
        paymentProcessor.ProcessPayment(200.00m);

        paymentProcessor.SetPaymentStrategy(new BitcoinPayment());
        paymentProcessor.ProcessPayment(50.00m);
    }
}