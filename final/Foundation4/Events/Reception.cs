using System;

public class Reception : Event
{
    private string _email;

    public Reception(string title, string desc, string date, string time, Address address, string email) : base(title, desc, date, time, address) {
        _email = email;
    }

    public void Short() {
        Console.WriteLine($"Reception\n{_title}\n{_desc}");
    }
    public void Full() {
        Console.WriteLine($"Reception\n{_title}\nRSVP to {_email}\n{_date} {_time}\n{_address.GetAddress()}\n{_desc}");
    }
}