using System;
using System.IO;
class Prompts
{

    public void Prompt()
    {        
        Console.WriteLine("Welcome to the Journal Program!");

        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1.Write a new Entry");
            Console.WriteLine("2.Display Journal");
            Console.WriteLine("3.Load journal from file");
            Console.WriteLine("4.Save journal.");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do: ");
        }
    }
}