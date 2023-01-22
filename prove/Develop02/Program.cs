using System;
using System.IO;
class Programer
{
    static void Main(string[] args)

    {
        int count = 1;
        JournalEntry Jentry = new JournalEntry();
        Console.WriteLine("Welcome to the Journal Program!");

        while(count != 0)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1.Write a new Entry");
            Console.WriteLine("2.Display Journal");
            Console.WriteLine("3.Load journal from file");
            Console.WriteLine("4.Save journal.");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do: ");
            string ans = Console.ReadLine();
            int ans2 = int.Parse(ans);
            
            if (ans2 == 1)
            {
                Jentry.choice();
            }

            else if (ans2 == 2)
            {
                Jentry.Display();
            }

            else if (ans2 == 3)
            {
                Jentry.Load();
            }
            else if (ans2 == 4)
            {
                Jentry.Save();
            }
            else if (ans2 == 5)
            {
                count = 0;
            }
            else
            {
                Console.WriteLine("Please choose");
            }
        }

    }


}
    