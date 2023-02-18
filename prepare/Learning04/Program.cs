using System;

class Program
{
    static void Main(string[] args)
    {
        
        MathsAssignment mathsAssignment = new MathsAssignment("Ezra Ato Brown", "Maths", "7.1", "8-19");
        mathsAssignment.GetSummary();
        mathsAssignment.GetHomeworkList();

        WrittingAssignment writtingAssignment = new WrittingAssignment("Ezra Ato Brown", "European History", "The cause of World War II");
        writtingAssignment.GetSummary();
        writtingAssignment.GetWrittingInfo();


    }
}