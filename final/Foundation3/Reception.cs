using System;

public class Reception : Events
{
    public string _rsvp= "";
    public string _address = "";
    
    public Reception(string emailrsvp, string title, string description, string date, string time, string address) : base(title, description, date, time,address)
    {
        _rsvp = emailrsvp;
    }
    public override void DisplayFullMessage()
    {
        base.DisplayFullMessage();
        Console.WriteLine($"Register: {_rsvp}");
    }
}