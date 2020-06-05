public class Zero : IElectric  // Electric motorcycle
{
    public double BatteryKWh { get; set; }


    public override string Name { get; set; } = "Zero";

    public int CurrentChargePercentage { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
}