namespace FactoryPattern;

public class PushNotifier : INotifier
{
    public void SendNotification(string msg)
    {
        Console.WriteLine(msg);
    }
}
