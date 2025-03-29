namespace task2
{
    public class PaymentProcessor
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                throw new InvalidOperationException("Стратегия оплаты не установлена.");
            }

            _paymentStrategy.Pay(amount);
        }
    }
}
