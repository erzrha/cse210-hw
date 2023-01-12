using System;

class Program
{
    static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
            
        }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static string PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string num = Console.ReadLine();
        return num;
    }
    static int SquareNumber()
    {
        int total= int.Parse(PromptUserNumber()); 
        return total*total;
    }
    static void DisplayResults()
    {
        
        Console.Write($"{PromptUserName()}, the square of your number is {SquareNumber()}");
    }
    static void Main(string[] args)
    {
        DisplayMessage();
        DisplayResults();
    }
}