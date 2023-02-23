using System;

public class Reflection : Activity
{
    Activity activity = new Activity();
    Random random = new Random();
    public Reflection()
    {
            _message = "Reflection";
            _description = "reflect on times in your life when you have shown strength and resilience, this will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void Reflect()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        activity.Animation();
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        Console.WriteLine("---Think of a time when you did something really difficult---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind press enter to continue.");
        
        var userInput = Console.ReadKey();
        if (userInput.Key == ConsoleKey.Enter)
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
            Console.Write("You may begin in: ");

            for (int i = 5; i > 0 ; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }


             DateTime futureTime = DateTime.Now.AddSeconds(num);
            while (DateTime.Now < futureTime)
            {
            string[] words = {"How did you feel when it was completed?", "What is your favorite thing about this experience?", "Who would you share this experience with? ", "Think of the people who helped you in the experince", "How did you seek divine help?"};
            int index = random.Next(words.Length);
            Console.WriteLine(" ");

            Console.Write(words[index]);
            activity.Animation();
            Console.WriteLine(" ");

        }
        }

    }
}
