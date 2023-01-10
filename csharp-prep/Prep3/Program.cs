using System;

class Program
{
    static void Main(string[] args)
    {   
       Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);
        int count = 0;
        while (count != 1)
        {
        
        Console.Write("What is your guess? ");
        string num = Console.ReadLine();
        int ans = int.Parse(num);
        
        if (ans > magic)
        {
            Console.WriteLine("Lower");
        }
        else if (ans < magic)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You guessed it!");
            count =1;
        }
    }
}
}