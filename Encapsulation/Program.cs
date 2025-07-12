public class Program
{
    static void Main()
    {
        Product product1 = new Product();
        Product.SetTotalNoProducts(Product.GetTotalNoProducts() + 1);

        product1.SetProductID(1001);
        product1.SetProductName("Mobile");
        product1.SetCost(20000);
        product1.SetQuantityInStock(1200);
        product1.CalculateTax();
        Product.SetTotalQuantityInStock(Product.GetTotalQuantityInStock() + product1.GetQuantityInStock());

        product1.PrintProductDetails();
        System.Console.WriteLine();

        Product product2 = new Product();
        Product.SetTotalNoProducts(Product.GetTotalNoProducts() + 1);

        product2.SetProductID(1002);
        product2.SetProductName("Laptop");
        product2.SetCost(45000);
        product2.SetQuantityInStock(3400);
        product2.CalculateTax();
        Product.SetTotalQuantityInStock(Product.GetTotalQuantityInStock() + product2.GetQuantityInStock());

        product2.PrintProductDetails();
        System.Console.WriteLine();

        Product product3 = new Product();
        Product.SetTotalNoProducts(Product.GetTotalNoProducts() + 1);

        product3.SetProductID(1003);
        product3.SetProductName("Desktop");
        product3.SetCost(36000);
        product3.SetQuantityInStock(800);
        product3.CalculateTax();
        Product.SetTotalQuantityInStock(Product.GetTotalQuantityInStock() + product3.GetQuantityInStock());

        product3.PrintProductDetails();
        System.Console.WriteLine();
    }
}