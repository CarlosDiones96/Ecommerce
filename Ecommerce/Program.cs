using Ecommerce.Classes;
using Ecommerce.Enums;

Product product = new Product(ProductCategories.Electronics, "cell phone", 500m);
Product product2 = new Product(ProductCategories.Electronics, "cell phone", 500m);
Product product3 = new Product(ProductCategories.Electronics, "cell phone", 500m);
Product product4 = new Product(ProductCategories.Electronics, "cell phone", 500m);


Console.WriteLine($"{product.Id} {product.Description} {product.Price} {product.Category}");

Cart c = new(product);
c.AddProduct(product2);
c.AddProduct(product3);
c.AddProduct(product4);

Console.WriteLine(c.TotalItems);
Console.WriteLine(c.TotalPrice);