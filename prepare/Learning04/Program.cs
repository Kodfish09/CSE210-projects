using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment a1 = new Assignment("Sara McCallister", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        MathAssignment a2 = new MathAssignment("William McKinley", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomework());

        WritingAssignment a3 = new WritingAssignment("Al Katal", "Asian History", "The Ming Dynasty");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetHomework());
    }
}