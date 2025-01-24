using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter;
        bool pass = false;

        if (grade >= 90) {
            letter = "A";
            pass = true;
        } else if (grade >= 80) {
            letter = "B";
            pass = true;
        } else if (grade >= 70) {
            letter = "C";
            pass = true;
        } else if (grade >= 60) {
            letter = "D";
        } else {
            letter = "F";
        }

        int lastDigit = grade%10;
        string symbol;
        if (lastDigit >= 7 && grade < 90 && grade > 60) {
            symbol = "+";
        } else if (lastDigit < 3 && grade < 90 && grade >= 60) {
            symbol = "-";
        } else {
            symbol = "";
        }

        Console.WriteLine($"You received {letter}{symbol}");

        if (pass == true) {
            Console.WriteLine("You passed!");
        } else{
            Console.WriteLine("You didn't pass. Do better next time!");
        }
    }
}