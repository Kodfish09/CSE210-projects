using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string desc, string date, string time, Address address, string weather) : base(title, desc, date, time, address) {
        _weather = weather;
    }

    public void Short() {
        Console.WriteLine($"Outdoor Gathering\n{_title}\n{_desc}");
    }
    public void Full() {
        Console.WriteLine($"Outdoor Gathering\n{_title}\n{_date} {_time}\n{_address.GetAddress()}\n{_desc}\nThe Weather will be {_weather}");
    }
}