using System;

public class Checklist : Goals
{
    private int _duration = 0; 
    private int count = 0;
    public Checklist() : base()
    {
        SetGoals();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _duration = Convert.ToInt32(Console.ReadLine());

        
    }

    public override string GetGoal()
    {
         return ($"[ ] {_name} {_description} {_points} -Completion {count}/{_duration}");
;
    }
}