using FactoryPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var notifier = new NotificationFactory();

        var smsNotifier = notifier.GetNotifier(NotificationTypes.SMS);
        var emailNotifier = notifier.GetNotifier(NotificationTypes.Email);
        var pushNotifier = notifier.GetNotifier(NotificationTypes.Push);

        smsNotifier.SendNotification("SMS notification sent.");
        emailNotifier.SendNotification("Email notification sent.");
        pushNotifier.SendNotification("Push notification sent.");
    }
}