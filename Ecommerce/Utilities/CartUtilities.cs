using Ecommerce.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Utilities
{
    public static class CartUtilities
    {
        public static decimal AddProductPrices(List<Product> products)
        {
            decimal total = 0;
            foreach (Product product in products)
                total += product.Price;

            return total;
        }

        public static long AddTotalItems(List<Product> products) =>
            products.Count();

    }
}
