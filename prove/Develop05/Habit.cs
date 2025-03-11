using System;

public class Habit : Goal
{
    public Habit(string name, string desc, int diff) : base (name, desc, diff){}

    public override int pointVal(List<Goal> goals)
    {
        int points = (_difficulty*50)+200;
        return points;
    }

    public override void setProg()
    {
        _prog = "";
    }
}