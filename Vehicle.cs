using System;

public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }
    public bool Moving = false;

    public virtual string Name { get; set; }
    public string Direction = "forward";
    public virtual void Turn(string direction)
    {
        if (Moving == true)
        {
            Console.WriteLine($"The {Name} is now moving {direction}");
            Direction = direction;
        }
        else
        {
            Console.WriteLine($"The {Name} can't turn if it's not moving!");
        }
    }
    public virtual void Drive()
    {
        Console.WriteLine($"The {Name} goes Vrooom!");
        Moving = true;
    }

    public virtual void Stop()
    {
        Console.WriteLine($"The {Name} goes Scrrreech");
        Moving = false;
    }
}