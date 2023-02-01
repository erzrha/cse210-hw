using System;

public class Fraction
{
    private int _top;
    private int _bottom; 

    public Fraction()
    {
    _top = 1;
    _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
     
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTopfraction()
    {
        return _top;
    }
    public void SetTopfraction(int top)
    {
        _top = top;
    }
    public int GetBottomfraction()
    {
        return _bottom;
    }
    public void SetBottomfraction(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        int num1 = (_top);
        int num2 = (_bottom);
        string str1 = num1.ToString();
        string str2 = num2.ToString();
        return str1 +"/"+ str2;
    }
    public double GetDecimalValue()
    {
        float top =  _top;
        float bottom = _bottom;
        return top/bottom;

        
    }
}