namespace task7
{
    class WeightConverter
    {
        public void PrintTableUsingWhile()
        {
            Console.WriteLine("Используя цикл while:");
            int pounds = 1;
            while (pounds <= 100)
            {
                double kilograms = ConvertToKilograms(pounds);
                Console.WriteLine($"{pounds} фунтов = {kilograms:F2} кг");
                pounds++;
            }
        }

        public void PrintTableUsingDoWhile()
        {
            Console.WriteLine("Используя цикл do while:");
            int pounds = 1;
            do
            {
                double kilograms = ConvertToKilograms(pounds);
                Console.WriteLine($"{pounds} фунтов = {kilograms:F2} кг");
                pounds++;
            } while (pounds <= 100);
        }

        public void PrintTableUsingFor()
        {
            Console.WriteLine("Используя цикл for:");
            for (int pounds = 1; pounds <= 100; pounds++)
            {
                double kilograms = ConvertToKilograms(pounds);
                Console.WriteLine($"{pounds} фунтов = {kilograms:F2} кг");
            }
        }

        private double ConvertToKilograms(int pounds)
        {
            return pounds * 0.45359237; // 1 фунт = 0.45359237 кг
        }
    }
}
