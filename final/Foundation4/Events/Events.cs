using System;

public class Event
{
    private protected string _title;
    private protected string _desc;
    private protected string _date;
    private protected string _time;
    private protected Address _address;

    public Event(string title, string desc, string date, string time, Address address) {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public void Standard() {
        Console.WriteLine($"{_title}\n{_date} {_time}\n{_address.GetAddress()}\n{_desc}");
    }
}