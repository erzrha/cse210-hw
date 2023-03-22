using System;

public class Goals
{
    protected string _name = " ";
    protected int _points = 0;

    protected string _description = " ";


    public void SetGoals()
    {

        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();     
        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of point associated with this goal? ");
        int my_points = Convert.ToInt32(Console.ReadLine());
        _points = my_points;
    } 
    public virtual string GetGoal()
    {
        return ($"[ ] {_name} ({_description}) {_points}");
    }
     public virtual string Save()
    {
        return ($"[ ] ,{_name} ,({_description}), {_points}");
    }
    public void SetfromSave(string name, string description, int point)
    {
        _name = name;
        _description = description;
        _points = point;
        Console.WriteLine($"[ ] {_name} {_description} {_points}");
    }
}
 