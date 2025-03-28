using System;

public class Reflection : Activity
{
    private List<string> prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];
    private List<string> questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];
    public string GetType() {
        return "Reflection";
    }
    public void Begin() {
        Console.WriteLine(sMsg);
        Wait(1);
        Console.WriteLine("Reflection Activity\n This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Wait(1);
        
        Console.WriteLine("How many seconds would you like to do this activity?");
        int time = int.Parse(Console.ReadLine());
        Wait(1);
        Console.WriteLine($"{prompts[new Random().Next(prompts.Count)]}");
        List<int> q = [0,1,2,3,4,5,6,7,8];
        int reps = 0;
        for (int i = 0; i < time; i++) {
            int s = new Random().Next(q.Count);
            Console.WriteLine($"{questions[q[s]]}");
            q.RemoveAt(s);
            Wait(10);
            i += 10;
            reps += 1;
        }

        Console.WriteLine(fMsg);
        Wait(2);
        Console.WriteLine($"You have successfully performed the Reflection Activity for {reps*10} seconds.");
        Wait(3);
    }
}