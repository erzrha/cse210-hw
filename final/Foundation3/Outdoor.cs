using System;

public class Outdoor : Events
{
    private string _weather = "";

    public Outdoor(string weather, string title, string description, string date, string time, string address) : base(title,description,date,time,address)
    {
        _weather = weather;
    }
    public override void DisplayFullMessage()
    {
        base.DisplayFullMessage();
        Console.WriteLine($"Weather: {_weather}");
    }
}