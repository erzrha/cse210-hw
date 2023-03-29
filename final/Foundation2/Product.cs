using System;

public class Product 
{
    private string _productName = " ";
    private string _product_id = " ";
    private int _price = 0;
    private int _quantity = 0;
    
    public List<int> _productprice = new List<int>();
    

    public Product(string name, string id, int price, int quantity)
    {
        _price = price;
        _productName = name;
        _quantity = quantity;
        _product_id = id;  
        _productprice.Add(_price);
    }
    public string DisplayProduct()
    {
        return($"ID: {_product_id} (Name: {_productName} Quantity: {_quantity} Price: {_price})");
    }
    public string GetName()
    {
        return _productName;
    }
    public string GetId()
    {
        return _product_id;
    }
    public void ProductPrice()
    {
        Console.WriteLine($"Total Price: {_price * _quantity}");
    }
 
}