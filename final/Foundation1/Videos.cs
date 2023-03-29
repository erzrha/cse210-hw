using System;

public class Videos
{
    public string _title = " ";
    public string _author = " ";

    public int _time = 0;
    int count = 0;
    Comments comments = new Comments();
    public List<string> _comments = new List<string>();

    public void SetTitle(string title)
    {
        _title = title;
    }
    
    public void SetAuthor(string author)
    {
        _author = author;
    }
 

    public void SetTime(int time)
    {
        _time = time;
    }

    public void DisplayMovie()
    {
        Console.WriteLine("Movie: ");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine ($"Author: {_author}");
        Console.WriteLine($"Time: {_time} seconds");
        Console.WriteLine("");
        Console.WriteLine("Comments");
        foreach (string comments in _comments)
        {
            count+=1;  
            Console.WriteLine(comments);
        }
            Console.WriteLine($"Number of Comments: {count}");

    }
    public void SetComments(string name, string text)
    {
        comments._name = name;
        comments._text = text;
        _comments.Add($"{comments.DisplayName()} {comments.DisplayText()} ");
        
    }

}