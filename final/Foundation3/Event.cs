public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    protected string _eventType;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = "";
    }

    public string DisplayStandardDetails()
    {
        // Lists the title, description, date, time, and address.
        return $"{_title} - {_description}\n{_date} @ {_time}\n{_address.Display()}";
    }

    public virtual string DisplayFullDetails()
    {
        // Lists all of the above, plus type of event and information specific to that event type.
        // For lectures, this includes the speaker name and capacity.
        // For receptions this includes an email for RSVP.
        // For outdoor gatherings, this includes a statement of the weather.
        return $"Type: {_eventType}\n{_title} - {_description}\n{_date} @ {_time}\n{_address.Display()}\n";
    }

    public string DisplayShortDescription()
    {
        // Lists the type of event, title, and the date
        return $"{_eventType} - {_title} - {_date}";
    }


}