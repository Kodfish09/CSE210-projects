using System;

public class Reference()
{
    private string _book;
    private string _chapter;
    private string _verses;

    public string GetReference() {
        return $"{_book} {_chapter}:{_verses}";
    }

    public void SetReference(string reff) {
        string[] reffDiv = reff.Split(" ");
        string b;
        string c;
        string v;

        if (reffDiv[0].Count() == 1) {
            b = $"{reffDiv[0]} {reffDiv[1]}";
            c = reffDiv[2].Split(":")[0];
            v = reffDiv[2].Split(":")[1];
        } else {
            b = reffDiv[0];
            c = reffDiv[1].Split(":")[0];
            v = reffDiv[1].Split(":")[1];
        }



        _book = b;
        _chapter = c;
        _verses = v;
    }
}