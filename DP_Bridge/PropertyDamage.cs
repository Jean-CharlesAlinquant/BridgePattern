namespace DesignPatterns.Bridge;

public class PropertyDamage : CarInsurance
{
    public PropertyDamage(int year, string make, string model, IDiscount discount)
        : base(year, make, model, discount)
    {
    }

    protected override decimal GetPremium()
    {
        return 60.00m;
    }
}