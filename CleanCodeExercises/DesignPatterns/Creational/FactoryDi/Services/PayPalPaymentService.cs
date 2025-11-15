using FactoryDi.Interfaces;

namespace FactoryDi.Services;

public class PayPalPaymentService : IPaymentProcessor
{
    public void ProcessPayment(string msg)
    {
        Console.WriteLine($"[Paypal] {msg}.");
    }
}
