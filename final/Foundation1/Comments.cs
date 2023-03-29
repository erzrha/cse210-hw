using System;

public class Comments
{
    public string _name = " ";
    public string _text = " ";

    public string DisplayName()
    {      
        return ($"Name: {_name}");
    
    }

    public string DisplayText()
    {
        return ($"Comment: {_text}");
    }
}