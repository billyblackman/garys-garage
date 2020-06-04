public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }
    public override string Name { get; set; } = "Tesla";
    public void ChargeBattery()
    {
        // method definition omitted
    }
}