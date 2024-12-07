using System;


class Vehicle
{

    protected int numOfWheels;

    public Vehicle(int wheels)
    {
        numOfWheels = wheels;
    }

    public virtual void ShowDetails()
    {
        Console.WriteLine($"Number of Wheels: {numOfWheels}");
    }
}


class Bus : Vehicle
{

    private double pricePerMile;
    private double miles;


    public Bus(int wheels, double pricePerMile, double miles) : base(wheels)
    {
        this.pricePerMile = pricePerMile;
        this.miles = miles;
    }


    public double CalculateCost()
    {
        return pricePerMile * miles;
    }


    public void ShowCost()
    {
        Console.WriteLine($"Cost for {miles} miles: ${CalculateCost()}");
    }


    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine($"Price per Mile: ${pricePerMile}");
        Console.WriteLine($"Miles: {miles}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Bus defaultBus = new Bus(4, 0.5, 100);
        Console.WriteLine("Bus Details:");
        defaultBus.ShowDetails();
        defaultBus.ShowCost();


        Bus paramBus = new Bus(6, 0.5, 200);
        Console.WriteLine("\nParameterized Bus Details:");
        paramBus.ShowDetails();
        paramBus.ShowCost();
        Console.ReadKey();
    }
}
