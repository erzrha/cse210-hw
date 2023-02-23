using System;

public class Breathing : Activity
{
    Activity activity = new Activity();


    public Breathing()
    {
            _message = "Breathing";
            _description = "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Breath()
    {
        Console.Clear();
       
        Console.WriteLine("Get Ready...");


        activity.Animation();
        Console.WriteLine("");
        
        DateTime futureTime = DateTime.Now.AddSeconds(num);
        while (DateTime.Now < futureTime)

            {   Console.Write("Breath in...");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    
                    
                }
                Console.WriteLine(" ");
                Console.Write("Breath Out...");
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    
                    
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
               
               
                
            }
            


    }
}