using System;

public class MathAssignment : Assignment
{
    //______________Attributes______________
    private string _textbookSection;
    private string _problems;
    
    //______________Constructors______________
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //______________Methods______________
    public string GetHomework() {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}