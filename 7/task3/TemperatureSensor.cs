namespace task3
{
    public class TemperatureSensor
    {
        public event TemperatureChangedHandler TemperatureChanged;

        private int _currentTemperature;

        public int CurrentTemperature
        {
            get => _currentTemperature;
            set
            {
                _currentTemperature = value;
                OnTemperatureChanged(_currentTemperature);
            }
        }

        protected virtual void OnTemperatureChanged(int temperature)
        {
            TemperatureChanged?.Invoke(temperature);
        }
    }
}
