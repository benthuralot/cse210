public abstract class Activity
{
    private string _date;
    private double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual string GetSummaryString()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeedMph().ToString("F2")} mph, Pace: {GetPaceMph().ToString("F2")} min per mile";
    }

    public abstract double GetDistance();

    public abstract double GetSpeedMph();

    public abstract double GetPaceMph();

    public double GetMinutes()
    {
        return _minutes;
    }
}