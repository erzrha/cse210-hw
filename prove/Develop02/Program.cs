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