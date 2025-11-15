using FactoryDi.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var factory = new PaymentServiceFactory();
        
        Console.WriteLine("----- Credit card payment ------");
        var creditCardPaymentService = factory.GetPaymentProcessor(PaymentTypes.CreditCard);
        creditCardPaymentService.ProcessPayment("Credit Card");

        Console.WriteLine();
        
        Console.WriteLine("----- PayPal payment ------");
        var payPalPaymentService = factory.GetPaymentProcessor(PaymentTypes.PayPal);
        payPalPaymentService.ProcessPayment("PayPal");
        
        Console.WriteLine();
        
        Console.WriteLine("----- Swish payment ------");
        var swishPaymentService = factory.GetPaymentProcessor(PaymentTypes.Swish);
        swishPaymentService.ProcessPayment("Swish");
    }
}