using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        first.SetTop(3);
        first.SetBottom(5);
        string firstValue = $"{first.GetFractionString()}  |||  {first.GetDecimalValue()}";

        Fraction second = new Fraction();
        second.SetTop(1);
        second.SetBottom(11);
        string secondValue = $"{second.GetFractionString()}  |||  {second.GetDecimalValue()}";

        Fraction third = new Fraction();
        third.SetTop(9);
        third.SetBottom(3);
        string thirdValue = $"{third.GetFractionString()}  |||  {third.GetDecimalValue()}";

        Console.WriteLine($"First: {firstValue}\nSecond: {secondValue}\nThird: {thirdValue}");
    }
}

