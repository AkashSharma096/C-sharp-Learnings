public class Product
{
    public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;
    public double tax;


    public void CalculateTax()
    {
        tax = (cost <= 20000) ?  cost * 10 / 100 : cost * 12.5 / 100;
    }
}

public class DomesticProduct : Product
{
    public void method1 ()
    {
        productID ++; // not valid
        productName = "abc"; // Accessible
        cost = 2000; // Accessible;
        quantityInStock = 0; // Accessible

    }


}

public class OtherClassInSameAssembly
{
    
 public void method1()
    {

        Product product3 = new Product();
        product3.productID = 1; // not valid
        product3.productName = "abc";
        product3.cost = 2000; // Accessible
        product3.quantityInStock = 10; // Accessible
    }

}