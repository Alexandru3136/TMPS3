using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3TMPS
{
    // Adapterul pentru serviciul de plată extern
    public class ExternalPaymentServiceAdapter : IPaymentService
    {
        private ExternalPaymentService _externalPaymentService;

        public ExternalPaymentServiceAdapter(ExternalPaymentService externalPaymentService)
        {
            _externalPaymentService = externalPaymentService;
        }

        public void Pay(double amount)
        {
            _externalPaymentService.MakePayment(amount);
        }
    }
}
