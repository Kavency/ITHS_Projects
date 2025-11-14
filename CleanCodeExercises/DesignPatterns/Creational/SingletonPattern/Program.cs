using Microsoft.Extensions.DependencyInjection;
using SingletonPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<ILogger, Logger>();

        var serviceProvider = serviceCollection.BuildServiceProvider();

        // Using different instances
        var nonSingletonLogger1 = new Logger();
        var nonSingletonLogger2 = new Logger();

        Console.WriteLine("---------- Non singleton ----------");
        
        nonSingletonLogger1.Log("This is not good.");
        nonSingletonLogger2.Log("This is even worse.");

        Console.WriteLine($"Same instance? {(ReferenceEquals(nonSingletonLogger1, nonSingletonLogger2) ? "Yes" : "No")}\n");

        // Using a singleton through DI
        var DiLogger1 = serviceProvider.GetService<ILogger>() ?? throw new Exception("No service found.");
        var DiLogger2 = serviceProvider.GetService<ILogger>() ?? throw new Exception("No service found.");

        Console.WriteLine("------------- DI Singleton -------------");
        DiLogger1.Log("Something happend.");
        DiLogger2.Log("Something else happend.");

        Console.WriteLine($"Same instance? {(ReferenceEquals(DiLogger1, DiLogger2) ? "Yes" : "No")}\n");

        // Using a manually created singleton
        var ManualLogger1 = SingletonLogger.GetInstance;
        var ManualLogger2 = SingletonLogger.GetInstance;

        Console.WriteLine("------------- Manual Singleton -------------");
        ManualLogger1.Log("Logging something.");
        ManualLogger2.Log("Also logging.");

        Console.WriteLine($"Same instance? {(ReferenceEquals(ManualLogger1, ManualLogger2) ? "Yes" : "No")}\n");
    }
}