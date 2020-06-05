using System;

public class Cessna : Vehicle, IGas
{
    public double FuelCapacity { get; set; }

    public override string Name { get; set; } = "Cessna";

    public int CurrentTankPercentage { get; set; } = 20;

    public void Refueltank()
    {
        CurrentTankPercentage = 100;
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