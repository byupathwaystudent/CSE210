
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address(
            "123 Main Street",
            "Salt Lake",
            "SLC",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        
        Product product1 = new Product("Keyboard", "KB100", 30, 2);
        Product product2 = new Product("Mouse", "MS200", 15, 1);
        Product product3 = new Product("Headset", "HS300", 45, 1);

        
        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        
        Address address2 = new Address(
            "123 The Grass Residences",
            "Quezon City",
            "Metro Manila",
            "Philippines"
        );

        Customer customer2 = new Customer("Jomel Lim-it", address2);

        
        Product product4 = new Product("Laptop Bag", "LB400", 25, 2);
        Product product5 = new Product("USB Drive", "USB500", 10, 3);
        Product product6 = new Product("Mouse Pad", "MP600", 8, 2);

        
        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        
        
        Console.WriteLine("             ORDER 1");
        

        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine();

        
        Console.WriteLine("             ORDER 2");
        
        

        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}
