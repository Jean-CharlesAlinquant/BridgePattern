namespace DesignPatterns.Bridge;

public abstract class CarInsurance
{
    private readonly IDiscount _discount;
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }

    protected CarInsurance(
        int year, string make, string model, IDiscount discount)
    {
        Year = year;
        Make = make;
        Model = model;

        _discount = discount;
    }

    public decimal CalculatePremium()
    {
        decimal normalPrice = GetPremium();
        decimal discountPortion = normalPrice * (_discount.GetDiscount() / 100m);
        return normalPrice - discountPortion;
    }

    protected abstract decimal GetPremium();
}
