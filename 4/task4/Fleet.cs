namespace task4
{
    public class Fleet
    {
        private Car[] cars;

        public Fleet(Car[] cars)
        {
            this.cars = cars;
        }

        public List<Car> GetNewestCars(int year)
        {
            return Car.GetNewestCars(cars, year);
        }

        public List<Car> GetCarsByBrand(string brand)
        {
            return Car.GetCarsByBrand(cars, brand);
        }
    }
}
