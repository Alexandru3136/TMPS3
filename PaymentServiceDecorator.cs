using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3TMPS
{
    // Decorator pentru serviciul de plată
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

}
