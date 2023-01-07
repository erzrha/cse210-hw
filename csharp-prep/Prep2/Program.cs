using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string ans = Console.ReadLine();
         int grade = int.Parse(ans);

         string grades = "";
        if (grade >= 90)
        {
            grades = "A";
        }

        else if (grade >=80 && grade <90)
        {
            grades = "B";
        }
        else if (grade >= 70 && grade <80)
        {
            grades = "C";
        }
        else if (grade >= 60 && grade <70)
        {
           grades = "D";
        }
        else{
            grades = "F";
        }

        Console.WriteLine($"Your grades is {grades}");
        if (grades == "D" || grades == "F")
        {
            Console.WriteLine("Don't give up...Better Luck next time");
        }
        else
        {
            Console.WriteLine("Congratulations, you made it!");
        }
    }
}