namespace DesignPatterns.Bridge;

// ConcreteImplementorA
public class SafeDriverDiscount : IDiscount
{
    public int GetDiscount()
    {
        return 10;
    }
}
