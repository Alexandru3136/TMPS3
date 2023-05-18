// Clasa Program
using L3TMPS;

class Program
{
    static void Main(string[] args)
    {
        // Utilizare Adapter
        ExternalPaymentService externalPaymentService = new ExternalPaymentService();
        IPaymentService paymentService = new ExternalPaymentServiceAdapter(externalPaymentService);
        paymentService.Pay(50);

        // Utilizare Decorator
        IPaymentService basePaymentService = new PaymentService();
        IPaymentService decoratedPaymentService = new PaymentServiceDecorator(basePaymentService);
        decoratedPaymentService.Pay(100);

        Console.ReadLine();
    }
}