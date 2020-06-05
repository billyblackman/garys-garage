public class Zero : Vehicle, IElectric  // Electric motorcycle
{
    public double BatteryKWh { get; set; }


    public override string Name { get; set; } = "Zero";

    public int CurrentChargePercentage { get; set; } = 45;

    public void ChargeBattery()
    {
        CurrentChargePercentage = 100;
    }
}