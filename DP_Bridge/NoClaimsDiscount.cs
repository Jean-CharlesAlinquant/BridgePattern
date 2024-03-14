namespace DesignPatterns.Bridge;

// ConcreteImplementorB
public class NoClaimsDiscount : IDiscount
{
    public int GetDiscount()
    {
        return 15;
    }
}
