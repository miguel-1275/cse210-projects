using System;

public class Cycling : Activity
{
    private double _speedMph;

    public Cycling(DateTime date, int minutes, double speedMph)
        : base(date, minutes)
    {
        _speedMph = speedMph;
    }

    public override double GetDistance()
    {
        double minutes = GetMinutes();
        return (_speedMph * (minutes / 60.0));
    }

    public override double GetSpeed()
    {
        return _speedMph;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        if (distance <= 0.0)
        {
            return 0.0;
        }
        double minutes = GetMinutes();
        return minutes / distance;
    }
}
