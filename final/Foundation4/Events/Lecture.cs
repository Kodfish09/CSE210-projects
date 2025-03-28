using System;

public class Lecture : Event
{
    private string _speaker;
    private int _cap;

    public Lecture(string title, string desc, string date, string time, Address address, string speaker, int cap) : base(title, desc, date, time, address) {
        _speaker = speaker;
        _cap = cap;
    }

    public void Short() {
        Console.WriteLine($"Lecture\n{_title}\n{_desc}");
    }
    public void Full() {
        Console.WriteLine($"Lecture\n{_title} by {_speaker}\n{_date} {_time}\n{_address.GetAddress()}\nCapacity: {_cap}\n{_desc}");
    }
}