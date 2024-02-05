public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWrittingInfo()
    {
        string name = GetName();
        string topic = GetTopic();

        return _title + " by " + name;
    }
}