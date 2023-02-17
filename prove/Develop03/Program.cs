using System;

class Program
{
    static void Main(string[] args)
     {
        Scripture scripture1 = new Scripture();
        Reference reference = new Reference();
        Word word = new Word();

//Created a scripture object
        //Set The reference
        reference._book = "John";
        reference._chapter = 10;
        reference._verse = 30;

        //sets the scripture text
        scripture1._text = "I and my father are one";

        
        //Gets the reference 
        reference.GetReference();

        //Puts the reference and scripture text into scripture
        scripture1.scripts(reference.refs, scripture1._text);
        
        //Displays the scripture
        scripture1.Display();
        
        //Display hidden scriptures
        word.Display(scripture1.hide);
        
    }
}
