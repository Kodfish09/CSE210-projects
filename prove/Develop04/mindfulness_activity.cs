using System;

class Activity
{
    private string start_message;
    private string finish_message;

    public void setMessages(string sMsg, string fMsg) {
        start_message = sMsg;
        finish_message = fMsg;
    }
    
    public void Wait (int time) {
        for (int i = time; i > 0; i--) {
            Console.Write("K");
            Thread.Sleep(250);
            
            Console.Write("a");
            Thread.Sleep(250);
            
            Console.Write("d");
            Thread.Sleep(250);
            
            Console.Write("e");
            Thread.Sleep(250);
            
        }
    }
}