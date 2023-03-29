using System;

public class Running : Activity
{
    protected int _distance = 0;
    public Running(int distance, string date, int minute) : base(date, minute, distance)
    {
        _distance = distance;
    }

    public int GetDistance()
    {


        return base.Distance(_distance, _lengthInMinute);
    }
}