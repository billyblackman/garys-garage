public class Tesla : Vehicle, IElectric
{
    public double BatteryKWh { get; set; }
    public override string Name { get; set; } = "Tesla";

    public int CurrentChargePercentage { get; set; } = 50;

    public void ChargeBattery()
    {
        CurrentChargePercentage = 100;
    }
}