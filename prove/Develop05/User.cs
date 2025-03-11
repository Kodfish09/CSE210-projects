using System;

public class User
{
    private int _cp = 0;
    private int _rp = 10;
    private int _level = 0;
    private int _rank = 1;
    private string _title = "Beggar";
    private string[] _titles = {
        "Beggar", "Laborer", "Peasent",
        "Aprentice", "Journeyman", "Master",
        "Grandmaster", "Mayor", "Noble",
        "Baron", "Viscount", "Count",
        "Earl", "Duke", "Courtier", 
        "Advisor", "Prince", "King",
        "Emperor", "Saint"
    };
    private List<Goal> goals = new List<Goal>();

    public void cheat(int p)
    {
        _cp += p;
        Console.WriteLine($"Your current points are: {_cp}");
    }

    public void displayStatus()
    {
        //Update Status___________________
        int updated = 0;
        while (updated != 3) {
            updated = 0;
            //Check Point Values__________________
            if (_cp >= _rp) {
                _cp -= _rp;
                _level += 1;
                _rp += _level * 10;
            } else {
                updated += 1;
            }
            //Check Level Value______________________
            if (_level >= _rank * 5) {
                _level -= _rank * 5;
                _rank += 1;
            } else {
                updated += 1;
            }
            //Check Rank___________________________________
            if (_rank < 20) {
                _title = _titles[_rank];
                updated += 1;
            }
        }

        //Display Status_____________________
        Console.WriteLine($"Level {_level} {_title}\n{_cp}/{_rp}\nPress Enter to continue. ");
        Console.ReadLine();
    }

    public void addGoal() {
        Console.WriteLine("What type of goal do you want to make? \n1. Achievement\n2. Habit\n3. Quest");
        int type = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your Goal's name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is the description of the Goal?");
        string desc = Console.ReadLine();

        Console.WriteLine("How difficult is this task on a scale of 1 to 10?");
        int diff = int.Parse(Console.ReadLine());

        if (type == 1) {
            goals.Add(new Achievement(name, desc, diff));
        } else if (type == 2) {
            goals.Add(new Habit(name, desc, diff));
        } else if (type == 3) {
            Console.WriteLine("How many times do you want to do this?");
            int target = int.Parse(Console.ReadLine());
            goals.Add(new Quest(name, desc, diff, target));
        } else {
            Console.WriteLine("You Fail");
        }
    }

    public void displayGoals()
    {
        int number = 1;
        foreach(Goal goal in goals) {
            if (goal is Quest) {
                Console.WriteLine($"{number}. {goal.getName()}\n{goal.getDesc()}\nDifficulty: {goal.getDiff()}\n{goal.getProg()}\n");
                number += 1;
            } else {
                Console.WriteLine($"{number}. {goal.getName()}\n{goal.getDesc()}\nDifficulty: {goal.getDiff()}\n\n");
                number += 1;
            }
        }
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    public void logEvent() 
    {
        displayGoals();

        Console.WriteLine("Which Goal are you logging an event for? Type the goal's number.");
        int goalNum = int.Parse(Console.ReadLine());
        Goal goal = goals[goalNum-1];
        int pointGain;

        if(goal is Achievement) {
            pointGain = goal.pointVal(goals);
            goals.Remove(goal);
        } else {
            pointGain = goal.pointVal(goals);
        }

        Console.WriteLine($"You gained {pointGain} points!");
        _cp += pointGain;
    }
}