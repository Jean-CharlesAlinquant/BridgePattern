namespace DesignPatterns.Bridge;

public class Comprehensive : CarInsurance
{
    public Comprehensive(int year, string make, string model, IDiscount discount)
        : base(year, make, model, discount)
    {
    }

    protected override decimal GetPremium()
    {
        return 165.00m;
    }
}
