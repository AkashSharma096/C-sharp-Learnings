using Products;
using ProductExtension;

namespace Programs
{
    public class Program
    {
        static void Main()
        {
            Product p1 = new Product() { productCost = 1000, discountPercentage = 10 };
            System.Console.WriteLine($"Product Discount - {p1.getDiscount()}");
        }
    }
}