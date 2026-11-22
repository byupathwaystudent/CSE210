
using System;

class Program
{
    static void Main(string[] args)
    {
        // CUSTOMER 1 - USA
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        // PRODUCTS FOR ORDER 1
        Product product1 = new Product("Keyboard", "KB100", 30, 2);
        Product product2 = new Product("Mouse", "MS200", 15, 1);
        Product product3 = new Product("Headset", "HS300", 45, 1);

        // CREATE ORDER 1
        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        // CUSTOMER 2 - PHILIPPINES
        Address address2 = new Address(
            "123 Quezon Avenue",
            "Quezon City",
            "Metro Manila",
            "Philippines"
        );

        Customer customer2 = new Customer("Maria Santos", address2);

        // PRODUCTS FOR ORDER 2
        Product product4 = new Product("Laptop Bag", "LB400", 25, 2);
        Product product5 = new Product("USB Drive", "USB500", 10, 3);
        Product product6 = new Product("Mouse Pad", "MP600", 8, 2);

        // CREATE ORDER 2
        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);


        // DISPLAY ORDER 1
        Console.WriteLine("==================================");
        Console.WriteLine("             ORDER 1");
        Console.WriteLine("==================================");

        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");


        // DISPLAY ORDER 2
        Console.WriteLine("\n==================================");
        Console.WriteLine("             ORDER 2");
        Console.WriteLine("==================================");

        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("----------------------------------");
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}
