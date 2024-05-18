public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic; 
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getters for the private member variables if I chose not to use "protected" for _studentName.
    public string GetStudentName()
    {
        return _studentName;
    }

}