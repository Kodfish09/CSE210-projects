using System;

class Breathing : Activity
{
    private string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public string breathe(int duration) {
        Console.WriteLine(duration);
        Console.WriteLine(description);
        for (int i = duration; i >= 0; i=i) {
            if (i % 2 == 1) {
                Console.WriteLine("Breathe in...");
            } else {
                Console.WriteLine("Breathe out...");
            }
            
            for (int j = 0; j <= 3; j++) {
                Thread.Sleep(1000);
                Console.WriteLine(i);
                i -= 1;
            }
        }
        return null;
    }
}