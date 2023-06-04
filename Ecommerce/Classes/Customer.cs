using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Classes
{
    public abstract class Customer
    {
        public readonly Guid Id;
        public string Name { get; private set; }
        public bool HasCreditCard { get; private set; }
        public bool HasMoneyToPay { get; private set; }
        public decimal BankAccountBalance { get; private set; }

        public Customer(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Customer(string name, bool hasCreditCard, bool hasMoneyToPay) : this(name)
        {
            HasCreditCard = hasCreditCard;
            HasMoneyToPay = hasMoneyToPay;
        }


        public void PayForProducts(List<Product> products, PaymentMethod payment) { }
    }
}
