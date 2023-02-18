using System;

public class WrittingAssignment : Assignment
{
    string _title = "";
    public WrittingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public void GetWrittingInfo()
    {
        string name = base._studentName;
        Console.WriteLine($"{_title} by {name}");
    }
}