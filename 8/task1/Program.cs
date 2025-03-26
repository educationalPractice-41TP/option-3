using static task1.Class1;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(100.00m); 

        try
        {
            account.Withdraw(150.00m);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"Текущий баланс: {account.Balance}");
        }
    }
}