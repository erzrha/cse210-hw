using System;

public class Scripture
{
    public Scripture()
    {

    }
    public string _text = "";
    List<string> listwords = new List<string>();
    public string hide = " ";
    
    // Set refernce and Scripture and Adds them to a list
    public void scripts(string reference, string _words)
    {
        string new_words = ($"{reference} {_words}");
        listwords.Add(new_words);
    }

    //Displays the original scripture text and words from the list
    public string Display()
    {
        foreach (string item in listwords)
        {
            Console.WriteLine(item);
            hide = item;
        }
            return hide;

    }
    public string GetScripture()
    {
        return hide;
    }    
}

