using System;

public class Comment
{
    private string _name;
    private string _txt;

    public Comment (string name, string txt) {
        _name = name;
        _txt = txt;
    }

    public string GetName() {
        return _name;
    }
    public string GetText() {
        return _txt;
    }
}