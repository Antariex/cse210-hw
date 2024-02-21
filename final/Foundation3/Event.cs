using System;

public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public DateTime Time { get; set; }
    public Address Address { get; set; }

    public Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string GetStandardDetails()
    {
        if (string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(Time.ToString("h:mm tt")))
        {
            return $"{Title}\nDate: {Date.ToShortDateString()}\nLocation: {Address.GetFullAddress()}";
        }
        return $"{Title}\n{Description}\nDate: {Date.ToShortDateString()} Time: {Time.ToString("h:mm tt")}\nLocation: {Address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event: {Title} on {Date.ToShortDateString()}";
    }
}
