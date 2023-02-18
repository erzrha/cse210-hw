using System;

public class Reference
//A reference has a book, chapter, and a verse.
{
    public string _book = "";
    public int _chapter = 0 ;
    public int _verse = 0 ;

    //Stores the reference
    public string refs = "";
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    //sets the reference information
    public string GetReference()
    {
        refs = ($"{_book} {_chapter}:{_verse}");
        return refs;
    } 
}