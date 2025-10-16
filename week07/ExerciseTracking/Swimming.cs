using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double meters = _laps * 50.0;
        double kilometers = meters / 1000.0;
        double miles = kilometers * 0.62;
        return miles;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        double minutes = GetMinutes();
        if (minutes <= 0.0 || distance <= 0.0)
        {
            return 0.0;
        }
        return (distance / minutes) * 60.0;
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
