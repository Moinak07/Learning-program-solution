using System;

class Program
{
    static void Main(string[] args)
    {
        // Sample of the product data
        Product[] products = {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shoes", "Fashion"),
            new Product(3, "Phone", "Electronics"),
            new Product(4, "Book", "Education"),
            new Product(5, "T-Shirt", "Fashion")
        };

        // Sorting the products by name for binary search
        Array.Sort(products, (p1, p2) => p1.ProductName.CompareTo(p2.ProductName));

        Console.WriteLine("Enter product name to search:");
        string nameToSearch = Console.ReadLine();

        // Code for Linear Search
        Product linearResult = SearchUtility.LinearSearch(products, nameToSearch);
        Console.WriteLine("\nLinear Search Result:");
        Console.WriteLine(linearResult != null ? linearResult.ToString() : "Product not found.");

        // Code for Binary Search
        Product binaryResult = SearchUtility.BinarySearch(products, nameToSearch);
        Console.WriteLine("\nBinary Search Result:");
        Console.WriteLine(binaryResult != null ? binaryResult.ToString() : "Product not found.");
    }
}

