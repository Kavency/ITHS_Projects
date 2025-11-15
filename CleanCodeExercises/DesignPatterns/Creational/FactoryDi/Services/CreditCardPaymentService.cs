using FactoryDi.Interfaces;

namespace FactoryDi.Services;

public class CreditCardPaymentService : IPaymentProcessor
{
    public void ProcessPayment(string msg)
    {
        Console.WriteLine($"[Credit card] {msg}.");
    }
}
