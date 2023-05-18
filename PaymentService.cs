using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3TMPS
{
    // Implementarea inițială a serviciului de plată
    public class PaymentService : IPaymentService
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Payment of $" + amount + " processed successfully.");
        }
    }
}
