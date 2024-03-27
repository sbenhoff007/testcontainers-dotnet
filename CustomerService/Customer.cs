namespace CustomerService;

public class Customers
{
    public readonly record struct Customer(long Id, string Name);
}
