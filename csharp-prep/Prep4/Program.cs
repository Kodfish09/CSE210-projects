using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        do {
            Console.WriteLine("Enter number: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        } while (numbers[^1] != 0);

        int sum = 0;
        foreach (int num in numbers) {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = sum/numbers.Count();
        Console.WriteLine($"The average is: {average}");

        int max = 0;
        foreach (int num in numbers) {
            if (num > max) {
                max = num;
            } 
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}