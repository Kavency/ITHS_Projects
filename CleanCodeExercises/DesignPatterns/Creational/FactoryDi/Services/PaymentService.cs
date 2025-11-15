using FactoryDi.Interfaces;

namespace FactoryDi.Services;

public class PaymentService(IPaymentProcessor _paymentProcessor) : IPaymentService
{
    public void ProcessPayment()
    {
        _paymentProcessor.ProcessPayment("Payment successful!");
    }
}
