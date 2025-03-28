using System;

public class Breathing : Activity
{
    public string GetType() {
        return "Breathing";
    }
    public void Begin() {
        Console.WriteLine(sMsg);
        Wait(1);
        Console.WriteLine("Breathing Activity\n This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Wait(1);
        Console.WriteLine("How many seconds would you like to do this activity?");
        int time = int.Parse(Console.ReadLine());
        int reps = 0;
        for (int i = 0; i < time; i++) {
            Console.WriteLine("Breath in...");
            Wait(5);
            i += 5;
            Console.WriteLine("Breath out...");
            Wait(5);
            i += 5;
            reps += 1;
        }
        Console.WriteLine(fMsg);
        Wait(2);
        Console.WriteLine($"You have successfully performed the Breathing Activity for {reps * 10} seconds.");
        Wait(3);
    }
}