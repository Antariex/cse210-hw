using System;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;



    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        string name = GetName();
        string topic = GetTopic();

        return "Section " + _textbookSection + " Problems " + _problems;
    }


}