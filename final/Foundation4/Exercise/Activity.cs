using System;

public abstract class Activity
{
    private protected string _date;
    private protected double _minutes;

    public Activity(string date, double minutes) {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public void GetSummary() {
        Console.WriteLine($"{_date} {this.GetType().Name} ({_minutes} min)-Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }
}