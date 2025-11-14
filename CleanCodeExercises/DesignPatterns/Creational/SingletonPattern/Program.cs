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

        Console.WriteLine("---------- Different instances ----------");
        
        nonSingletonLogger1.Log("This is not good.");
        nonSingletonLogger2.Log("This is even worse.");

        Console.WriteLine($"Same instance? {(ReferenceEquals(nonSingletonLogger1, nonSingletonLogger2) ? "Yes" : "No")}\n");

        // Using a singleton
        var logger1 = serviceProvider.GetService<ILogger>();
        var logger2 = serviceProvider.GetService<ILogger>();

        Console.WriteLine("------------- Same instance -------------");
        logger1.Log("Something happend.");
        logger2.Log("Something else happend.");

        Console.WriteLine($"Same instance? {(ReferenceEquals(logger1, logger2) ? "Yes" : "No")}\n");
    }
}