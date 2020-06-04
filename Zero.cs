public class Zero : Vehicle  // Electric motorcycle
{
    public double BatteryKWh { get; set; }

    public override string Name { get; set; } = "Zero";
    public void ChargeBattery()
    {
        // method definition omitted
    }
}