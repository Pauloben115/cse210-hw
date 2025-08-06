using System;

class Program
{
    static void Main(string[] args)
    {
        // USA Customer
        Address address1 = new Address("123 Elm St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B001", 10.00, 2));
        order1.AddProduct(new Product("Pen", "P002", 1.50, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // International Customer
        Address address2 = new Address("456 Maple St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "N003", 5.00, 4));
        order2.AddProduct(new Product("Pencil", "P004", 0.50, 6));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
