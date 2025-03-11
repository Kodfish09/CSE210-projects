using System;

public class Achievement : Goal
{
    public Achievement(string name, string desc, int diff) : base (name, desc, diff){}
    public override int pointVal(List<Goal> goals)
    {
        int points = 10 * _difficulty;
        return points;
    }
    public override void setProg()
    {
        _prog = "";
    }
}