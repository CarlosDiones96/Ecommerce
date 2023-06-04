using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Classes
{
    public abstract class Store
    {
        public static long TotalItemsInStock { get; protected set; } = 0;
        public decimal TotalSold { get; private set; } = 0m;
        public List<string> ProductsToAddToStock { get; private set; }
        public List<Product> Products { get; set; }

        public Store()
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product) { }
        public void RemoveProduct(Product product) { }
        public void ClearCart() { }
        public void Checkout() { }

    }
}
