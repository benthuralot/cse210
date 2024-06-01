using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Products
        Product prod = new Product("milk", "001", 3.56, 3);
        Product prod1 = new Product("eggs", "002", 6.77, 1);
        Product prod2 = new Product("bread", "003", 2.50, 4);
        Product prod3 = new Product("butter", "004", 4.69, 2);
        Product prod4 = new Product("flour", "005", 5.0, 1);
        Product prod5 = new Product("rice", "006", 4.50, 2);
        Product prod6 = new Product("noodles", "007", 1.49, 12);
        
        // Create Addresses
        Address nzAddress = new Address("4 Korcula Place", "Auckland", "AKL", "New Zealand");
        Address ausAddress = new Address("17 Adelaide Avenue", "Canberra", "ACT", "Australia");
        Address usAddress = new Address("123 Elm Street", "New York City","NY", "USA");
        
        // Create Customers with their Orders
        Customer customerHershyl = new Customer("Hershyl Seumanu", nzAddress);
        Order order1 = new Order(customerHershyl);
        order1.AddProduct(prod);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);
        order1.AddProduct(prod3);

        // Create an American Customer
        Customer customerTala = new Customer("Talafua Lotoa", usAddress);
        Order order2= new Order(customerTala);
        order2.AddProduct(prod1);
        order2.AddProduct(prod2);

        Customer customerShan = new Customer("Shannon Sullivan", ausAddress);
        Order order3 = new Order(customerShan);
        order3.AddProduct(prod4);
        order3.AddProduct(prod5);
        order3.AddProduct(prod6);
        

        Console.WriteLine($"Order1\n");
        Console.WriteLine(order1.DisplayPackingLabel());
        Console.WriteLine(order1.DisplayShippingLabel());
        Console.WriteLine($"\nTotal Cost: {order1.CalculateTotalCost().ToString("C2")}(shipping included +$10)");

        Console.WriteLine();

        Console.WriteLine($"Order2\n");
        Console.WriteLine(order2.DisplayPackingLabel());
        Console.WriteLine(order2.DisplayShippingLabel());
        Console.WriteLine($"\nTotal Cost: {order2.CalculateTotalCost().ToString("C2")}(shipping included +$10)");

        Console.WriteLine();

        Console.WriteLine($"Order3\n");
        Console.WriteLine(order3.DisplayPackingLabel());
        Console.WriteLine(order3.DisplayShippingLabel());
        Console.WriteLine($"\nTotal Cost: {order3.CalculateTotalCost().ToString("C2")}(shipping included +$10)");
       
       

    }
}