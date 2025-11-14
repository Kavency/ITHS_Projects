namespace DependencyInjection;

// A class that don't use DI and uses the new keyword to create dependencies. (Tight coupling).
public class OrderService
{
    private EmailNotifier _emailNotifier;

    public OrderService()
    {
        _emailNotifier = new EmailNotifier();
    }

    public void ProcessOrder(string msg)
    {
        _emailNotifier.SendNotification(msg);
    }
}
