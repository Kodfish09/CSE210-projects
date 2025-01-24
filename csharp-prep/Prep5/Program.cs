using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string uName = PromptUserName();
        Console.WriteLine("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        int sqNum = SquareNumber(num);
        DisplayResults(uName, sqNum);
    }

    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName() {
        Console.WriteLine("Please enter your name: ");
        string uName = Console.ReadLine();
        return uName;
    }

    static int SquareNumber(int num) {
        return num * num;
    }

    static void DisplayResults(string uName, int sqNum) {
        Console.WriteLine($"{uName} the square of your number is: {sqNum}");
    }
}