namespace task5
{
    public abstract class Vehicle
    {
        public abstract void Move();
        public virtual void Stop() 
        {
            Console.WriteLine("Vehicle is stopping.");
        }
    }
}