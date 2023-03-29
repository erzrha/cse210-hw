using System;

public class Swimming : Activity
{
    private int _swimlap = 0;
    public Swimming(int lap, string date, int minutes) : base(date, minutes, lap)
    {
        _swimlap = lap;
    }

    public double GetPace()
    {
        return base.Pace(_swimlap,_lengthInMinute);
    }
}