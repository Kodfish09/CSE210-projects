using System;

public abstract class Goal
{
    private protected string _name;
    private protected string _description;
    private protected int _difficulty;
    private protected string _prog;

    //Constructor_______________________________________________
    public Goal(string name, string desc, int diff){
        _name = name;
        _description = desc;
        _difficulty = diff;
    }

    //Get and Setters_______________________________________________
    public string getProg() {
        return _prog;
    }
    public abstract void setProg();
    public void setName(string name) {
        _name = name;
    }
    public void setDesc(string desc) {
        _description = desc;
    }
    public void setDiff(int diff) {
        _difficulty = diff;
    }
    public string getName() {
        return _name;
    }
    public string getDesc() {
        return _description;
    }
    public int getDiff() {
        return _difficulty;
    }

    //Methods_______________________________________________

    public abstract int pointVal(List<Goal> goals);
}