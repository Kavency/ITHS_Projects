namespace FactoryPattern;

public class EmailNotifier : INotifier
{
    public void SendNotification(string msg)
    {
        Console.WriteLine(msg);
    }
}
