using System;

public class Fraction
{
    private float _top;
    private float _bottom;

    //Constructors
    public Fraction () {
        _top = 1;
        _bottom = 1;
    }
    public Fraction (int wholeNumber) {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction (int top, int bottom) {
        _top = top;
        _bottom = bottom;
    }

    //Getters
    public float GetTop()
    {
        return _top;
    }
    public float GetBottom()
    {
        return _bottom;
    }
    //Setters
    public void SetTop(int top) 
    {
        _top = top;
    }
    public void SetBottom(int bottom) 
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }
    public float GetDecimalValue() 
    {
        float dec = _top/_bottom;
        return dec;
    }
}