using System;

public class Activity 
{
    protected string _date = "";
    protected int _lengthInMinute = 0;
    protected int _distance = 0;
    protected int _speed = 0;
    protected int  _pace =0;

   

    public Activity(string date, int minute, int distance)
    {
        _date = date;
        _lengthInMinute = minute;
        _distance = distance;
    }
    public virtual int Distance(int dis, int len )
    {
        _distance = (dis*len)*60;
        return _distance;
       
    }

    public virtual int Speed(int dis, int len)
    {
        _speed = (dis/len)*60;
        return _speed;
    }

    public virtual int Pace(int dis, int len)
    {
        _pace = (dis*50)/1000;
        return _pace;
        
    }
    public void Summary()
    {
        _distance = Distance(_distance, _lengthInMinute); 
        _speed = Speed(_distance, _lengthInMinute);
        _pace = Pace(_distance, _lengthInMinute);

        Console.WriteLine($"{_date} Running: ({_lengthInMinute} min) - Distance: {_distance} km, Speed: {_speed} kmph) Pace: {_pace} min per km");
    }
}

