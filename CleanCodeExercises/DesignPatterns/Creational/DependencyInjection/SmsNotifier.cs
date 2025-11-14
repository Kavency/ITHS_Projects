namespace DependencyInjection;

public class SmsNotifier : INotifier
{
    public void SendNotification(string msg)
    {
        Console.WriteLine($"[SMS notifier]: {msg}");
    }
}
