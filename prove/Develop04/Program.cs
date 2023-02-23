using System;

public class Programmer
{
    static void Main(string[] args)
    {
        int count =0;
        while (count != 1)
        {
        Console.Clear();

        Console.WriteLine("Menu Option");
        Console.WriteLine(" 1. Start breathing activity");
        Console.WriteLine(" 2. Start reflecting activity");
        Console.WriteLine(" 3. Start listening activity");
        Console.WriteLine(" 4. Quit");
        Console.Write("Select a choice from the menu: ");

        int userInput = Convert.ToInt32(Console.ReadLine());
        
        if (userInput == 1)
        {
            Console.Clear();
            Breathing breathing = new Breathing();
            breathing.DisplayMessage();
            breathing.Duration();
            breathing.Breath();
            breathing.EndMessage();
        }

        else if (userInput == 2)
        {
            Console.Clear();
            Reflection reflection = new Reflection();
            reflection.DisplayMessage();
            reflection.Duration();
            reflection.Reflect();
            reflection.EndMessage();

        } 

        else if (userInput == 3)
        {
            Console.Clear();
            Listening listening = new Listening();
            listening.DisplayMessage();
            listening.Duration();
            listening.Listen();
            listening.EndMessage();
        } 

        else if (userInput == 4)
        {

            Console.WriteLine("Bye Bye..");
            count =1;
        } 

    }
}
}