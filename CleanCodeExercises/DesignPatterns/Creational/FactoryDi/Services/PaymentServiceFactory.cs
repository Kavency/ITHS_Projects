using FactoryDi.Interfaces;

namespace FactoryDi.Services;

public enum PaymentTypes
{
    PayPal,
    CreditCard,
    Swish
}

public class PaymentServiceFactory : IPaymentServiceFactory
{
    public IPaymentProcessor GetPaymentProcessor(PaymentTypes type)
    {
        return type switch
        {
            PaymentTypes.PayPal => new PayPalPaymentService(),
            PaymentTypes.CreditCard => new CreditCardPaymentService(),
            PaymentTypes.Swish => new SwishPaymentService(),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
