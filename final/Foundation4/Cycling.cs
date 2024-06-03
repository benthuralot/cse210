public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

     public override double GetDistance()
    {
        double hours = GetMinutes() / 60;
        return _speed * hours;
    }

    public override double GetSpeedMph()
    {
        return _speed;
    }

    public override double GetPaceMph()
    {
        return GetMinutes() / GetDistance();
    }
}