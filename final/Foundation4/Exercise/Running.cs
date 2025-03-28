using System;

public class Running : Activity
{
    private double _dist;

    public Running(string date, double minutes, double dist) : base(date, minutes) {
        _dist = dist;
    }

    public override double GetDistance()
    {
        return _dist;
    }
    public override double GetSpeed()
    {
        return (_dist / _minutes) * 60;
    }
    public override double GetPace()
    {
        return _minutes / _dist;
    }
}