using System;

public class Product
{
    private int productID;
    private string productName;
    private double cost;
    private int quantityInStock;
    private double tax;
    public static int totalNoProducts;
    public static int totalQuantityInStock;


    public void SetProductID(int productID)
    {
        this.productID = productID;
    }

    public void SetProductName(string productName)
    {
        this.productName = productName;
    }
    
    public void SetCost(double cost)
    {
        this.cost = cost;
    }

    public void SetQuantityInStock(int quantityInStock)
    {
        this.quantityInStock = quantityInStock;
    }

    public static void SetTotalNoProducts(int totalProducts)
    {
        totalNoProducts = totalProducts;
    }
    public static void SetTotalQuantityInStock(int totalQuantity)
    {
        totalQuantityInStock = totalQuantity;
    }


    public void CalculateTax()
    {
        tax = (cost <= 20000) ? cost * 10 / 100 : cost * 12.5 / 100;
    }

    public int GetProductID()
    {
        return productID;
    }

    public string GetProductName()
    {
        return productName;
    }

    public double GetCost()
    {
        return cost;
    }

    public int GetQuantityInStock()
    {
        return quantityInStock;
    }

    public double GetTax()
    {
        return tax;
    }

    public static int GetTotalNoProducts()
    {
        return totalNoProducts;
    }

    public static int GetTotalQuantityInStock()
    {
        return totalQuantityInStock;
    }

    public void PrintProductDetails()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        System.Console.WriteLine("Product ID: " + GetProductID());
        System.Console.WriteLine("Product Name: " + GetProductName());
        System.Console.WriteLine("Product Cost: " + GetCost());
        System.Console.WriteLine("Product Quantity in Stock: " + GetQuantityInStock());
        System.Console.WriteLine("Product Tax: " + GetTax());
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.WriteLine("\n********** Summary **********");
        System.Console.WriteLine("Total Number of Products: " + GetTotalNoProducts());
        System.Console.WriteLine("Total Quantity in Stock: " + GetTotalQuantityInStock());
        System.Console.WriteLine("********** Summary **********\n");
        Console.ForegroundColor = ConsoleColor.DarkGray;

    }

}