using System;

public class Listening : Activity
{
Activity activity = new Activity();
 public Listening()
    {
            _message = "Listening";
            _description = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Listen()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        activity.Animation();
        Console.WriteLine("");
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine("---When have you felt the HolyGhost this month? ---");
        Console.WriteLine("");
        
        Console.Write("You may begin in: ");
        int count = 0;
            for (int i = 5; i > 0 ; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
             DateTime futureTime = DateTime.Now.AddSeconds(num);
             Console.WriteLine("");
            while (DateTime.Now < futureTime)
            {
                
                Console.Write("> ");
                Console.ReadLine();
                count += 1;
            }
            Console.WriteLine($"You listed {count} items");
    }
}