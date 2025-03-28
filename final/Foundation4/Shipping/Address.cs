using System;

public class Address
{
    private string _saddress;
    private string _city;
    private string _sp;
    private string _country;

    public Address(string sa, string c, string sp, string co) {
        _saddress = sa;
        _city = c;
        _sp = sp;
        _country = co;
    }

    public bool isUSA() {
        if (_country.Contains("United States") || _country.Contains("USA")) {
            return true;
        } else {
            return false;
        }
    }

    public string GetAddress() {
        return $"{_saddress}\n{_city}, {_sp} {_country}";
    }
}