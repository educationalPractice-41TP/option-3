using task5;

namespace task5
{
    public class Car : Vehicle
    {
        public override void Move() 
        {
            Console.WriteLine("Car is moving.");
        }

        public override void Stop() 
        {
            Console.WriteLine("Car is stopping.");
        }
    }
}