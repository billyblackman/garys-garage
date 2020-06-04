using System;

public class Ram : Vehicle  // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public override string Name { get; set; } = "Ram";


    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"Sorry, the Ram can only go {Direction}");
    }
}