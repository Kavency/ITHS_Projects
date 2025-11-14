namespace DependencyInjection;

public class EmailNotifier : INotifier
{
    public void SendNotification(string msg)
    {
        Console.WriteLine($"[Email notifier]: {msg}");
    }
}
