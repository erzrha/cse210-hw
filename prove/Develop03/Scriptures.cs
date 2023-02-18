using System;

public class Scripture
{
     public string _text = "";
     public string _reference = " ";
    public string hide = " ";

    public Scripture( string reference, string text)
    {
        _text = text;
        _reference = reference;

    }
   
    
    // Set refernce and Scripture and Adds them to a list
    public string SetScripture()
    {
        hide = ($"{_reference} {_text}");
        Console.WriteLine(hide);
        return hide;
    }
}

