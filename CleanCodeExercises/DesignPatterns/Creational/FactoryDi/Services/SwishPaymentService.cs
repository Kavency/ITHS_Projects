using FactoryDi.Interfaces;

namespace FactoryDi.Services;

public class SwishPaymentService : IPaymentProcessor
{
    public void ProcessPayment(string msg)
    {
        Console.WriteLine($"[Swish] {msg}.");
    }
}
