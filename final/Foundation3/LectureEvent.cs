public class LectureEvent : Event
{
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    public LectureEvent(string title, string description, DateTime date, DateTime time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}
