using Ecommerce.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Classes
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Description { get; set; }
        public decimal Price { get; private set; }
        public ProductCategories Category { get; set; }

        public Product(ProductCategories category, string description, decimal price)
        {
            Id = Guid.NewGuid();
            Description = description;
            Price = price;
            Category = category;
        }

        public void UpdatePrice(decimal newPrice)
        {
            Price = newPrice;
        }
    }
}
