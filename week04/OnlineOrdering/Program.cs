using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address = new Address("France", "16 Rue Alfred de Vigny, 16000", "Paris");
        Customer customer = new Customer("Tyler Nelson", address);
        Product cheese1= new Product("Smelly Cheese", "B234", 15.35m, 4);
        Product cheese2= new Product("Bleu Cheese", "B344", 11.32m, 5);
        List<Product> cheeseOrder = new List<Product>();
        cheeseOrder.Add(cheese1);
        cheeseOrder.Add(cheese2);
        Order order1 = new Order(customer, cheeseOrder);
        Product comics1 = new Product("Mickey Mouse Adventures Vol. 1 - 3", "A113", 30.32m, 3);
        Product comics2 = new Product("Valerian Vol. 1 - 2", "A113", 20.45m, 2);
        List<Product> comicsOrder = new List<Product>();
        comicsOrder.Add(comics1);
        comicsOrder.Add(comics2);
        Order order2 = new Order (customer, comicsOrder);

        Console.WriteLine($"Total Price= {order1.CalculateTotalPrice()}");
        Console.WriteLine($"{order1.CreatePackingLabel()}");
        Console.WriteLine($"{order1.CreateShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine($"Total Price= {order2.CalculateTotalPrice()}");
        Console.WriteLine($"{order2.CreatePackingLabel()}");
        Console.WriteLine($"{order2.CreateShippingLabel()}");

    }
}