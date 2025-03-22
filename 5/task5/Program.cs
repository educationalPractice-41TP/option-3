using task5;

class Program
{
    static void Main(string[] args)
    {
        Vehicle myCar = new Car();
        Vehicle myBicycle = new Bicycle();

        myCar.Move(); 
        myCar.Stop(); 

        myBicycle.Move(); 
        myBicycle.Stop();
    }
}
