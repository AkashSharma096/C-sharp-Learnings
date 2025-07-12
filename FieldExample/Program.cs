using System.Security.Cryptography.X509Certificates;

class Sample
{

    static void Main()
    {
        //create objects

        Product product1 = new Product();
        Product product2 = new Product();
        Product product3 = new Product();

        //initialize Fields

        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 1200;

        product2.productID = 1002;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantityInStock = 3400;

        product3.productID = 1003;
        product3.productName = "Speaker";
        product3.cost = 36000;
        product3.quantityInStock = 800;

        product1.CalculateTax();
        product2.CalculateTax();
        product3.CalculateTax();

        //get values as output

        System.Console.WriteLine("Product ID: " + product1.productID);
        System.Console.WriteLine("Product Name: " + product1.productName);
        System.Console.WriteLine("Product Cost: " + product1.cost);
        System.Console.WriteLine("Product Quantity in Stock: " + product1.quantityInStock);
        System.Console.WriteLine("Product Tax: " + product1.tax);

        System.Console.WriteLine();

        System.Console.WriteLine("Product ID: " + product2.productID);
        System.Console.WriteLine("Product Name: " + product2.productName);
        System.Console.WriteLine("Product Cost: " + product2.cost);
        System.Console.WriteLine("Product Quantity in Stock: " + product2.quantityInStock);
        System.Console.WriteLine("Product Tax: " + product2.tax);

        System.Console.WriteLine();

        System.Console.WriteLine("Product ID: " + product3.productID);
        System.Console.WriteLine("Product Name: " + product3.productName);
        System.Console.WriteLine("Product Cost: " + product3.cost);
        System.Console.WriteLine("Product Quantity in Stock: " + product3.quantityInStock);
        System.Console.WriteLine("Product Tax: " + product3.tax);

        int totalQuantity = product1.quantityInStock + product2.quantityInStock + product3.quantityInStock;

        System.Console.WriteLine("\n\nTotal Quantity is " + totalQuantity);

    }
}

public class InternationalProduct : Product
{
    public void method1()
    {
        productID++; // not valid
        productName = "abc"; // Accessible
        cost = 2000; // Accessible;
        quantityInStock = 0; // Accessible
    }

}

public class OtherClassInOtherAssembly
{
    public void method1()
    {

        Product product3 = new Product();
        product3.productID = 1; // not valid
        product3.productName = "abc"; // not valid
        product3.quantityInStock = 10; // not valid
    }


}