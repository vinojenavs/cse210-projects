using System;
using System.Reflection.Metadata.Ecma335;
public class Fraction
{
    private int _top;
    private int _bottom;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholenumber)
    {
        _top = wholenumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    /** 
    public void GetTop()
    {
        Console.WriteLine($"{_top}");
    }
    public void SetTop()
    {
        Console.WriteLine("Set the numerator: ");
        string numerator = Console.ReadLine();
        int top = int.Parse(numerator);
    }
    public void GetBottom()
    {
        Console.WriteLine($"{_bottom}");
    }
    public void SetBottom()
    {
        Console.WriteLine("Set the debominator: ");
        string denominator = Console.ReadLine();
        int _bottom = int.Parse(denominator);
    }
    **/
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}