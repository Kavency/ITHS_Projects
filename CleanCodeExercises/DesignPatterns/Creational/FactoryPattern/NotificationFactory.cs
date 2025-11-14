namespace FactoryPattern;

public enum NotificationTypes
{
    SMS,
    Email,
    Push
}


public class NotificationFactory
{
    public INotifier GetNotifier(NotificationTypes type)
    {
        switch (type)
        {
            case NotificationTypes.SMS:
                return new SmsNotifier();
                
            case NotificationTypes.Email:
                return new EmailNotifier();

            case NotificationTypes.Push:
                return new PushNotifier();
                
            default:
                throw new ArgumentOutOfRangeException("Bad type.");
        }
    }
}
