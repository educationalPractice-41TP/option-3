using task3;

public delegate void TemperatureChangedHandler(int temperature);

class Program
{
    static void Main(string[] args)
    {
        TemperatureSensor sensor = new TemperatureSensor();

        CoolingSystem coolingSystem = new CoolingSystem();
        WarningSystem warningSystem = new WarningSystem();

        sensor.TemperatureChanged += coolingSystem.OnTemperatureChanged;
        sensor.TemperatureChanged += warningSystem.OnTemperatureChanged;

        sensor.CurrentTemperature = 26;
        sensor.CurrentTemperature = 31; 
    }
}