public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base (title, description, date, time, address)
    {
        _weather = weather;
        _eventType = "Outdoor";
    }

    public override string DisplayFullDetails()
    {
        // Lists all of the above, plus type of event and information specific to that event type.
        // For lectures, this includes the speaker name and capacity.
        return base.DisplayFullDetails() + $"Weather: {_weather}";
    }
}