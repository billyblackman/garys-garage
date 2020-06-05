using System;

public class Ram : Vehicle, IGas  // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public override string Name { get; set; } = "Ram";

    public int CurrentTankPercentage { get; set; } = 0;

    public void Refueltank()
    {
        CurrentTankPercentage = 100;
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"Sorry, the Ram can only go {Direction}");
    }
}