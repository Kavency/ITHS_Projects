using FactoryDi.Services;

namespace FactoryDi.Interfaces;

public interface IPaymentServiceFactory
{
    IPaymentProcessor GetPaymentProcessor(PaymentTypes type);
}
