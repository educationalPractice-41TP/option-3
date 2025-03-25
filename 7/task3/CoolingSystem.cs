namespace task3
{
    public class CoolingSystem
    {
        public void OnTemperatureChanged(int temperature)
        {
            if (temperature > 25)
            {
                Console.WriteLine("CoolingSystem: Включение кондиционера.");
            }
        }
    }
}
