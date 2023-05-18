using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3TMPS
{
    // Interfața pentru serviciul de plată
    public interface IPaymentService
    {
        void Pay(double amount);
    }
}
