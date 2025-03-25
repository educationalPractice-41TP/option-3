namespace task3
{
    public class WarningSystem
    {
        public void OnTemperatureChanged(int temperature)
        {
            if (temperature > 30)
            {
                Console.WriteLine("WarningSystem: Внимание! Перегрев!");
            }
        }
    }
}
