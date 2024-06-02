public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base (title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }

    public override string DisplayFullDetails()
    {
        // Lists all of the above, plus type of event and information specific to that event type.
        // For lectures, this includes the speaker name and capacity.
        return base.DisplayFullDetails() + $"Speaker: {_speaker}\nCapacity: {_capacity}";
    }
}