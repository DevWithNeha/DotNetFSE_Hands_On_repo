using System;

class Program
{
    static Product[] products =
    {
        new Product(101,"Laptop","Electronics"),
        new Product(102,"Phone","Electronics"),
        new Product(103,"Shoes","Fashion"),
        new Product(104,"Watch","Accessories"),
        new Product(105,"Bag","Fashion")
    };

    static Product LinearSearch(int id)
    {
        foreach (Product p in products)
        {
            if (p.ProductId == id)
                return p;
        }
        return null;
    }

    static Product BinarySearch(Product[] arr, int id)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid].ProductId == id)
                return arr[mid];

            if (arr[mid].ProductId < id)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        Console.Write("Enter Product ID : ");
        int id = int.Parse(Console.ReadLine());

        Product result = LinearSearch(id);

        Console.WriteLine("\nLinear Search");

        if (result != null)
            Console.WriteLine(result.ProductName + " " + result.Category);
        else
            Console.WriteLine("Product Not Found");

        Array.Sort(products);

        result = BinarySearch(products, id);

        Console.WriteLine("\nBinary Search");

        if (result != null)
            Console.WriteLine(result.ProductName + " " + result.Category);
        else
            Console.WriteLine("Product Not Found");
    }
}