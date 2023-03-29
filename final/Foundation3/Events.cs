using System;

public class  Events
{
    private string _title = "";
    private string _description = "";
    private string _date = " ";
    private string _time = " ";
    private string _address = "";

    public Events(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public void DisplayStandardMessage()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine();
    }
    public virtual void DisplayFullMessage()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine();


    }
    public void DisplayShortDescription()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine();

    }
}