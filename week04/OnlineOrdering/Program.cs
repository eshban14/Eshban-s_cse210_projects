using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Address address2 = new Address("2 Ziverbey St", "Baku", "ON", "Azerbaijan");

            
            Customer customer1 = new Customer("Eshban Younis", address1);
            Customer customer2 = new Customer("Sarah Younis", address2);

          
            Product product1 = new Product("Laptop", "L100", 889.99, 2);
            Product product2 = new Product("Mouse", "M1002", 19.99, 1);
            Product product3 = new Product("Keyboard", "K1003", 45.99, 2);
            Product product4 = new Product("Monitor", "M1004", 289.99, 1);

           
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);

            Console.WriteLine("Order 1 Details:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");

            Console.WriteLine("Order 2 Details:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}\n");
        }
    }
}