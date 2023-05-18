using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3TMPS
{
    // Serviciul de plată extern
    public class ExternalPaymentService
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine("External payment of $" + amount + " processed successfully.");
        }
    }
}
