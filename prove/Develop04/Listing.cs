using System;

public class Listing : Activity
{
    private List<string> prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    public string GetType() {
        return "Listing";
    }
    public void Begin() {
        Console.WriteLine(sMsg);
        Wait(1);
        Console.WriteLine("Listing Activity\n This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Wait(1);
        Console.WriteLine("How many seconds would you like to do this activity?");
        int time = int.Parse(Console.ReadLine());

        Console.WriteLine($"{prompts[new Random().Next(prompts.Count)]}");
        Console.WriteLine("You have 10 seconds to think before you must begin listing.");
        for (int i = 9; i > 0; i--) {
            Wait(1);
            Console.WriteLine(i);
        }

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        List<string> list = [];
        while (DateTime.Now < futureTime) {
            string item = Console.ReadLine();
            list.Add(item);
        }

        Console.WriteLine("Time's up!");
        Wait(3);
        foreach(string s in list) {
            Console.WriteLine(s);
        }

        Wait(5);
        Console.WriteLine(fMsg);
        Wait(2);
        Console.WriteLine($"You have successfully performed the Breathing Activity for {time} seconds.");
        Wait(3);
    }
}