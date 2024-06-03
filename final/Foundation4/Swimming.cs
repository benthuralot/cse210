public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

     public override double GetDistance()
    {
        return _laps * 50  / 1000.0 * 0.62;
    }

    public override double GetSpeedMph()
    {
        return GetDistance() / GetMinutes() * 60;
    }

    public override double GetPaceMph()
    {
        return GetMinutes() / GetDistance();
    }
}