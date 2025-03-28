using System;

public class Activity
{
    private protected string sMsg = "Welcome!";
    private protected string fMsg = "Great job!";

    public string GetSMsg() {
        return sMsg;
    }
    public string GetFMsg() {
        return fMsg;
    }

    public void Wait(int time) {
        Thread.Sleep(time*1000);
    }
}