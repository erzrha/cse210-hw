using System;

class Program
{
    static void Main(string[] args)
    {
        List<Events> _events = new List<Events>();
        Lecture lecture = new Lecture("Ezra",40, "Bitcoin", "How To Grow Bitcoin", "23-09-2023", "10:30", "Accra");
        Outdoor outdoor = new Outdoor("23 degrees", "Picnic", "YSA picnic", "23-04-2023", "2pm", "Canada");
        Reception reception = new Reception("eatobrown@hotmailcom", "Wedding", "Wedding of Mr.and Mrs Ato Brown", "29-04-2023", "11am", "Kasoa");

        _events.Add(lecture);
        _events.Add(outdoor);
        _events.Add(reception);

        foreach (Events events in _events)
        {
            Console.WriteLine("Full Event Details");
            Console.WriteLine("---------------");

            events.DisplayFullMessage();
            Console.WriteLine();

            Console.WriteLine("Short Event Description");
            Console.WriteLine("---------------");


            events.DisplayShortDescription();
            Console.WriteLine();

            Console.WriteLine("Standard Event Details");
            Console.WriteLine("---------------");

            events.DisplayStandardMessage();
        }

    }
}