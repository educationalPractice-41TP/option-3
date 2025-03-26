namespace task1
{
    internal class Class1
    {
        public class InsufficientFundsException : Exception
        {
            public InsufficientFundsException() { }

            public InsufficientFundsException(string message) : base(message) { }

            public InsufficientFundsException(string message, Exception innerException)
                : base(message, innerException) { }
        }

        public class BankAccount
        {
            public decimal Balance { get; private set; }

            public BankAccount(decimal initialBalance)
            {
                Balance = initialBalance;
            }

            public void Withdraw(decimal amount)
            {
                if (amount > Balance)
                {
                    throw new InsufficientFundsException("Недостаточно средств на счете для снятия этой суммы.");
                }
                Balance -= amount;
            }
        }
    }
}
