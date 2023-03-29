using System;

class Program 
{
    static void Main(string[] args)
    {
        int countdown = 1;

        List<Order> _order = new List<Order>();
        while (countdown !=0)
        {
            Console.Clear();
            Console.WriteLine("Fill in your orders below");
            Console.Write("Product Name: ");
            string p_name = (Console.ReadLine());
            Console.Write("Product ID: ");
            string p_id = (Console.ReadLine());
            Console.Write("Price: ");
            int price = (Convert.ToInt32(Console.ReadLine()));
            Console.Write("Quantity: ");
            int quantity = (Convert.ToInt32(Console.ReadLine()));
            
            Order order = new Order(p_name, p_id, price, quantity);
            _order.Add(order);

            Console.WriteLine();
            Console.WriteLine("1. Keep Ordering");
            Console.WriteLine("2. Quit");
            Console.Write("> ");
            int choice = (Convert.ToInt32(Console.ReadLine()));
            if (choice == 1)
            {
                countdown = 1;
            }
            else
            {
                countdown = 0;
            }

        }
        Console.Clear();
        Console.WriteLine("Fill in your name and address");

        Console.Write("Name: ");
        string name = (Console.ReadLine());
        Console.Write("Street: ");
        string street = (Console.ReadLine());
        Console.Write("City: ");
        string city = (Console.ReadLine());
        Console.Write("State: ");
        string state = (Console.ReadLine());
         Console.Write("Country: ");
        string country= Console.ReadLine();
        Customer customer = new Customer(name, street, city, state, country);


        int count = 0;
        
        Console.Clear();
        foreach (Order orders in _order)
        {
            Console.WriteLine(orders.DisplayProduct());
            orders.PackingLabel();
            orders.ProductPrice();
            count += orders.TotalOrderCost();
            Console.WriteLine();
        }
            
            if (country == "USA" || country == "America")
            {
                Console.WriteLine($"Total Order price: {count + 5}");

            }

            else
            {
                Console.WriteLine($"Total Order price: {count + 35}");

            }
            
            Console.WriteLine(customer.ShippingLabel());

    }  
}