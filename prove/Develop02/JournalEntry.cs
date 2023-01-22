using System;
using System.IO;
public class JournalEntry
{

    List<string> _entry = new List<string>(); 
    DateTime theCurrentTime = DateTime.Now;
    public void choice() 
    {
        
        string dateText = theCurrentTime.ToShortDateString();
        Random randomGenerator = new Random();
        string[] my_choice = {"•Who was the most interesting person I interacted with today?", "What was the best part of my day?","•How did I see the hand of the Lord in my life today?", "•What was the strongest emotion I felt today?", "•If I had one thing I could do over today what would it be?"};
        int index = randomGenerator.Next(my_choice.Length);
        Console.WriteLine("Write a new Entry: ");
        Console.WriteLine(my_choice[index]);
        string prompt_ans = Console.ReadLine();
        
        _entry.Add($"{dateText} - Prompt: {my_choice[index]}");
        _entry.Add(prompt_ans);
        _entry.Add("");
    } 
    public void Display()
    {
    
        foreach (string item in _entry)
                {
                    Console.WriteLine(item);
                    
                    
                }
    }
     public void Save()
    {
        Console.Write("Save as: ");
        string create_file= Console.ReadLine();
        List<string> lines = new List<string>();
        foreach (string item in _entry)
                {
                    lines.Add(item);
                    
                    
                }
                File.WriteAllLines(create_file, lines);
    }
    public void Load()
    {
        Console.Write("Open File: ");
        string File_name = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(File_name);
        foreach (string line in lines)
            {
                _entry.Add(line);
                    
                    
            }
    }
}
