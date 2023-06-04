using Ecommerce.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Classes
{
    public class Cart
    {
        public List<Product> Products { get; private set; }
        public long TotalItems { get; private set; }
        public decimal TotalPrice { get; private set; }

        public Cart(Product product)
        {
            Products = new List<Product>();
            AddProduct(product);
        }

        public void RemoveItem(Product product) 
        {
            if (Products.Contains(product))
                Products.Remove(product);
        }

        public void AddProduct(Product product) 
        {
            Products.Add(product);
            TotalItems = CartUtilities.AddTotalItems(Products);
            TotalPrice = CartUtilities.AddProductPrices(Products);
        }
    }
}
