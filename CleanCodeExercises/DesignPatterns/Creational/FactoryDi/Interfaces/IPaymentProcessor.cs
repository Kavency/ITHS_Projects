namespace FactoryDi.Interfaces;

public interface IPaymentProcessor
{
    void ProcessPayment(string msg);
}
