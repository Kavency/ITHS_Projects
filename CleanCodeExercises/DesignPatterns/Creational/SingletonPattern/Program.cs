using Microsoft.Extensions.DependencyInjection;
using SingletonPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddSingleton<ILogger, Logger>();

        var serviceProvider = serviceCollection.BuildServiceProvider();

        var logger1 = serviceProvider.GetService<ILogger>();
        var logger2 = serviceProvider.GetService<ILogger>();

        logger1.Log("Something happend.");
        logger2.Log("Something else happend.");

        Console.WriteLine($"Same instance? {(ReferenceEquals(logger1, logger2) ? "Yes" : "No")}");
    }
}