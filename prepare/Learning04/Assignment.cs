using System;
using Microsoft.VisualBasic;

public class Assignment
{
    //______________Attributes______________
    private string _studentName;
    private string _topic;

    //______________Constructors______________
    public string GetStudentName() {
        return _studentName;
    }
    public Assignment(string studentName, string topic) {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetTopic() {
        return _topic;
    }

    //______________Methods______________
    public string GetSummary() {
        string msg = $"{_studentName} - {_topic}";
        return msg;
    }
}