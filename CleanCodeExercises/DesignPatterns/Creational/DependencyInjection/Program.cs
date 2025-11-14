using DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var orderService = new OrderService();
        Console.WriteLine("------ Usage of service with no DI, tight coupling. ------");
        orderService.ProcessOrder("This is sent without DI.");

        Console.WriteLine();

        Console.WriteLine("------ Usage of service with DI, loose coupling. ------");
        var smsNotifier = new SmsNotifier();
        var diOrderService = new DiOrderService(smsNotifier);
        diOrderService.ProcessOrder("This is sent with DI.");

        Console.WriteLine();

        Console.WriteLine("------ Usage of service, injecting different notifier. ------");
        var emailNotifier = new EmailNotifier();
        diOrderService = new DiOrderService(emailNotifier);
        diOrderService.ProcessOrder("Sent with DI, injecting different notifier.");

    }
}