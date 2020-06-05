public class Tesla : IElectric
{
    public double BatteryKWh { get; set; }
    public override string Name { get; set; } = "Tesla";

    public int CurrentChargePercentage { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
}