using System;

public class WritingAssignment : Assignment
{
    //______________Attributes______________
    private string _title;

    //______________Constructors______________
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    //______________Methods______________
    public string GetHomework() {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}