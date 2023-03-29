using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();
        Cycling cycling = new Cycling(23, "23 Jan 2023", 23);
        Running running = new Running(4,"23 Jan 2023", 30);
        Swimming swimming = new Swimming(4, "30 June 2022", 30);

        _activities.Add(cycling);
        _activities.Add(running);
        _activities.Add(swimming);

        foreach (Activity activities in _activities)
        {
            activities.Summary();
        }
    }
}