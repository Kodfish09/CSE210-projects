using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        bool con = true;

        while (con == true) 
        {
            Console.WriteLine("1. Add New Goal\n2. Display all Goals\n3. Log Event\n4. Display Status\n5. Quit");
            int action = int.Parse(Console.ReadLine());

            if (action == 1) {
                user.addGoal();
            } else if (action == 2) {
                user.displayGoals();
            } else if (action == 3) {
                user.logEvent();
            } else if (action == 4) {
                user.displayStatus();
            } else if (action > 5) {
                user.cheat(action);
            } else {
                Console.WriteLine("Farewell!");
                con = false;
            }
        }
    }
}