using System;

class Program
{
    static void Main(string[] args)
    {
        bool j = true;
        List<string> ba = [];
        List<string> ra = [];
        List<string> la = [];
        while (j == true) {
            Console.WriteLine("Menu Options:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) {
                Breathing breathing = new Breathing();
                breathing.Begin();
                ba.Add(breathing.GetType());
            } else if (choice == 2) {
                Reflection reflection = new Reflection();
                reflection.Begin();
                ra.Add(reflection.GetType());
            } else if (choice == 3) {
                Listing listing = new Listing();
                listing.Begin();
                la.Add(listing.GetType());
            } else if (choice == 4) {
                j = false;
            } else {
                Console.WriteLine("Please enter a valid choice. 1-4");
            }
        }
        Console.WriteLine($"Breathing: {ba.Count} Reflection: {ra.Count} Listing: {la.Count}");
    }
}