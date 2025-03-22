using task5;

namespace task5
{
    public class Bicycle : Vehicle
    {
        public override void Move() 
        {
            Console.WriteLine("Bicycle is moving.");
        }

        public override void Stop() 
        {
            Console.WriteLine("Bicycle is stopping.");
        }
    }
}