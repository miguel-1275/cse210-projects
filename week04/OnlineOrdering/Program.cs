using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Maple Street", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak Avenue", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Emily Johnson", address2);

        // Create products
        Product product1 = new Product("Laptop", 101, 999.99, 1);
        Product product2 = new Product("Mouse", 102, 25.50, 2);
        Product product3 = new Product("Keyboard", 103, 45.75, 1);

        Product product4 = new Product("Notebook", 201, 5.99, 5);
        Product product5 = new Product("Pen Set", 202, 12.50, 2);

        // Create first order and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create second order and add products
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order 1 information
        Console.WriteLine("----- Order 1 -----");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.OrderTotalPrice():F2}");
        Console.WriteLine();

        // Display order 2 information
        Console.WriteLine("----- Order 2 -----");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.OrderTotalPrice():F2}");
    }
}
