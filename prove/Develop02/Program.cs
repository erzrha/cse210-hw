using System;
using System.IO;
class Programer
{
    static void Main(string[] args)

    {
        int count = 1;
        JournalEntry Jentry = new JournalEntry();
        Prompts prompts = new Prompts();
        
        while(count != 0)
        {
            prompts.Prompt();
            
            string ans = Console.ReadLine();
            int answer = int.Parse(ans);
                
            if (answer == 1)
            {
                Jentry.choice();
            }

            else if (answer == 2)
            {
                Jentry.Display();
            }

            else if (answer == 3)
            {
                Jentry.Load();
            }
            else if (answer == 4)
            {
                Jentry.Save();
            }
            else if (answer == 5)
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