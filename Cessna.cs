using System;

public class Cessna : Vehicle
{
    public double FuelCapacity { get; set; }

    public override string Name { get; set; } = "Cessna";
    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {Name} goes Zoooooom!");
        Moving = true;
    }

    public override void Stop()
    {
        Console.WriteLine($"The {Name} rolls to a stop");
        Moving = false;
    }
}