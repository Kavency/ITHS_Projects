namespace FactoryPattern;

public class SmsNotifier : INotifier
{
    public void SendNotification(string msg)
    {
        Console.WriteLine(msg);
    }
}
