using System;

public class MathsAssignment : Assignment
{
    private string _textbookSection = " ";
    private string _problems = " ";

    public MathsAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine($"Section {_textbookSection} Problem {_problems}");
    }
}