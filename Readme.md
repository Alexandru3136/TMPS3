**În acest proiect, voi implimenta următoarele design pattern-uri ”Adapter” și ”Decorator”:**
**Adapter: Sablonul Adapter convertește interfața unei clase într-o altă interfață așteptată de client. Acesta permite colaborarea între două clase cu interfețe incompatibile. Adapterul acționează ca un intermediar între client și obiectul incompatibil, transformând apelurile din interfața clientului în apeluri corespunzătoare în interfața obiectului incompatibil.**
**Decorator: Sablonul Decorator permite adăugarea de comportamente suplimentare la un obiect într-un mod flexibil și dinamic, fără a afecta structura sa de bază. Acesta utilizează compunerea obiectelor, permițând atașarea de obiecte decorator adiționale la un obiect de bază. Fiecare decorator adaugă comportamente noi la obiectul de bază, oferind astfel o funcționalitate extinsă.**
**În continuare e prezentat codul unde, avem interfața IPaymentService, care definește metoda Pay() pentru serviciul de plată.**

public interface IPaymentService
{
    void Pay(double amount);
}

**Avem clasa PaymentService, care reprezintă implementarea inițială a serviciului de plată. Aceasta implementează interfața IPaymentService.**

public class PaymentService : IPaymentService
{
    public void Pay(double amount)
    {
        Console.WriteLine("Payment of $" + amount + " processed successfully.");
    }
}

**Avem clasa ExternalPaymentService, care reprezintă un serviciu de plată extern. Acesta nu implementează interfața IPaymentService, dar este adaptat prin intermediul clasei ExternalPaymentServiceAdapter, care implementează interfața IPaymentService și utilizează serviciul de plată extern pentru a procesa plățile.**

public class ExternalPaymentService
{
    public void MakePayment(double amount)
    {
        Console.WriteLine("External payment of $" + amount + " processed successfully.");
    }
}

**Avem clasa PaymentServiceDecorator, care servește drept decorator pentru serviciul de plată. Acesta primește un obiect de tip IPaymentService și adaugă un comportament suplimentar înainte și/sau după apelul metodei Pay() a obiectului de bază.**

public class PaymentServiceDecorator : IPaymentService
{
    private IPaymentService _paymentService;

    public PaymentServiceDecorator(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public void Pay(double amount)
    {
        _paymentService.Pay(amount);
        Console.WriteLine("Additional processing for the payment.");
    }
}

**În metoda Main(), exemplificăm utilizarea Adapterului prin intermediul serviciului de plată extern și a Decoratorului prin intermediul serviciului de plată decorat. Se efectuează plăți folosind aceste servicii, iar rezultatele sunt afișate în consolă.**

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