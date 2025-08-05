using System;

class Program
{
    static void Main(string[] args)
    {
         Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LP1001", 899.99, 1));
        order1.AddProduct(new Product("Mouse", "MS300", 25.50, 2));

        Address address2 = new Address("77 Maple Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Martin", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "KB200", 49.99, 1));
        order2.AddProduct(new Product("Monitor", "MN700", 199.99, 1));
        order2.AddProduct(new Product("USB Cable", "UC500", 9.99, 3));

        Address address3 = new Address("23 Airport Rd", "Warri", "Delta", "Nigeria");
        Customer customer3 = new Customer("Steph Curry", address3);

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Laptop", "DD546", 849.99, 1));
        order3.AddProduct(new Product("USB Cable", "UJ520", 9.99, 3));


        List<Order> orders = new List<Order> { order1, order2, order3 };

        int orderNumber = 1;
        foreach (var order in orders)
        {
            Console.WriteLine($"Order {orderNumber}");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
            Console.WriteLine();
            orderNumber++;
        }
    }
}