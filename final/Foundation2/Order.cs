using System;

public class Order : Product 
{
    int count = 0;
    List<Customer> _customers = new List<Customer>();
    List<string> _product = new List<string>();

    public Order(string name, string id, int price, int quantity) :base(name, id, price,quantity)
    {
        _product.Add($"{name} {id} {price} {quantity}");
    }
    public int TotalOrderCost()
    {
        foreach (int item in _productprice)
        {
            count += item;
        }
        return (count);
    }

    public void PackingLabel()
    {
        Console.WriteLine($"Prodct Name: {GetName()}");
        Console.WriteLine($"Product ID: {GetId()}");
    }

  }

