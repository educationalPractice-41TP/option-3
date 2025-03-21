using task4;

class Program
{
    static void Main(string[] args)
    {
        Car[] cars = {
            new Car("Toyota", "Camry", 2021, 15000),
            new Car("Honda", "Civic", 2019, 30000),
            new Car("Ford", "Mustang", 2020, 10000),
            new Car("Toyota", "Corolla", 2022, 5000),
            new Car("Honda", "Accord", 2018, 45000)
        };

        Fleet fleet = new Fleet(cars);

        var newestCars = fleet.GetNewestCars(2019);
        Console.WriteLine("Автомобили, выпущенные после 2019 года:");
        foreach (var car in newestCars)
        {
            Console.WriteLine($"{car.Brand} {car.Model} ({car.Year})");
        }

        var toyotaCars = fleet.GetCarsByBrand("Toyota");
        Console.WriteLine("\nАвтомобили марки Toyota:");
        foreach (var car in toyotaCars)
        {
            Console.WriteLine($"{car.Brand} {car.Model} ({car.Year})");
        }
    }
}
