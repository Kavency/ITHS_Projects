namespace DependencyInjection;

public class DiOrderService(INotifier _notifier)
{
    public void ProcessOrder(string msg)
    {
        _notifier.SendNotification(msg);
    }
}
