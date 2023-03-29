using System;

public class Lecture : Events
{
    private string _lectsname = "";
    private int _capacity = 0;

    public Lecture(string name, int capacity, string title, string description, string date, string time, string address) : base(title, description, date, time, address)
    {
        _lectsname = name;
        _capacity = capacity;
    }

    public override void DisplayFullMessage()
    {
         Console.WriteLine($"Lectures Name: {_lectsname}");
        Console.WriteLine($"Capacity: {_capacity}");
        base.DisplayFullMessage();
       
    }

}