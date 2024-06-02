public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base (title, description, date, time, address)
    {
        _email = email;
        _eventType = "Reception";
    }

    public override string DisplayFullDetails()
    {
        // Lists all of the above, plus type of event and information specific to that event type.
        // For lectures, this includes the speaker name and capacity.
        return base.DisplayFullDetails() + $"RSVP: {_email}";
    }
}