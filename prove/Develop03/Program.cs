// See https://aka.ms/new-console-template for more information
using System;

class Programer 
{
    static void Main(string[] args)
    {
        string text = "If any of you lack wisdom, let him ask of God that giveth to all men liberally and upbraideth not and it shall be given him";
        Reference reference = new Reference("James", 1, 7);
        reference.GetReference();

        //sets scripture reference and text 
        Scripture scripture1 = new Scripture(reference.refs, text);

        scripture1.SetScripture();
        
        Word word = new Word(scripture1.hide); 

        
        
    }
}
