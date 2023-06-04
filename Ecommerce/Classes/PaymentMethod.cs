using Ecommerce.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Classes
{
    public class PaymentMethod
    {
        public PaymentOptions ChosenPaymentMethod { get; protected set; }

        public PaymentMethod(PaymentOptions options)
        {
            ChosenPaymentMethod = options;
        }
    }
}
