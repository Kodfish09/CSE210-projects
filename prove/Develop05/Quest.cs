using System;
using System.Runtime;
using Microsoft.VisualBasic.FileIO;

public class Quest : Goal
{
    private int _reps = 0;
    private int _target;

    public Quest(string name, string desc, int diff, int target) : base (name, desc, diff)
    {
        _target = target;
        setProg();
    }

    public override int pointVal(List<Goal> goals)
    {
        int points = 0;
        _reps += 1;
        if (_reps == _target) {
            points = _difficulty * 100;
            goals.Remove(this);
        } else {
            points = _difficulty * 10;
        }
        setProg();
        return points;
    }

    public override void setProg()
    {
        _prog = $"{_reps}/{_target}";
    }
}