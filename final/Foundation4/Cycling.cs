using System;

public class Cycling : Activity
{

    public Cycling(int speed, string date, int minute) : base(date, minute, speed)
    {
        _speed = speed;
    }

    public int Getspeed()
    {
        return base.Speed(_speed, _lengthInMinute);
    }
}