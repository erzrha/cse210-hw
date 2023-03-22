using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        List<Goals> goal_list = new List<Goals>();
        List<string> loaded = new List<string>();
        int count = 1;


         while (count !=0)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Events");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select a choice from the menu: ");

            int my_choice = Convert.ToInt32(Console.ReadLine());

            if (my_choice == 1)
            {
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");

                Console.WriteLine("Which type of goal would you like to create? ");
                int my_choice2 = Convert.ToInt32(Console. ReadLine());
                if (my_choice2 == 1)
                {
                    Simple simple = new Simple();
                    goal_list.Add(simple);
                }

                if (my_choice2 == 2)
                {
                    Eternal eternal = new Eternal();   
                    goal_list.Add(eternal);
                }
                if (my_choice2 == 3)
                { 
                    Checklist checklist = new Checklist();
                    goal_list.Add(checklist);
                    
                }

            }
            else if(my_choice == 2)
            {
                int count2 = 0;
                foreach (string item in loaded)
                    {
                        count2 += 1;
                        Console.WriteLine($"{count2} {item}");
                    }
                foreach (Goals goals in goal_list)
                {
                    count2+=1;
                    Console.WriteLine($"{count2} {goals.GetGoal()}");
                    
                }
            }
            else if(my_choice == 3)
            {
                Console.Write("Save as: ");
                string create_file= Console.ReadLine();
                List<string> lines = new List<string>();
                foreach (Goals goals in goal_list)
                { 
                    lines.Add($"{goals}: {goals.GetGoal()}");
                }
                File.WriteAllLines(create_file, lines);
            }
            
            else if(my_choice == 4)
            {
                Console.Write("Open File: ");
                string File_name = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(File_name);
                foreach (string line in lines)
                {
                    loaded.Add(line);
                }
            }
            else if(my_choice == 6)
            {
                count =0;
            }

        }
        
    }
}