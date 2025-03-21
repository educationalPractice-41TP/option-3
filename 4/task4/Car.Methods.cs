namespace task4
{
    public partial class Car
    {
        public static List<Car> GetNewestCars(Car[] cars, int year)
        {
            return cars.Where(car => car.Year > year).ToList();
        }

        public static List<Car> GetCarsByBrand(Car[] cars, string brand)
        {
            return cars.Where(car => car.Brand.Equals(brand, System.StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
