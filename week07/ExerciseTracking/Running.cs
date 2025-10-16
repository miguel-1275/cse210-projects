using System;

public class Running : Activity
{
    private double _distanceMiles;

    public Running(DateTime date, int minutes, double distanceMiles)
        : base(date, minutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return _distanceMiles;
    }

    public override double GetSpeed()
    {
        double minutes = GetMinutes();
        if (minutes <= 0 || _distanceMiles <= 0.0)
        {
            return 0.0;
        }
        return (_distanceMiles / minutes) * 60.0;
    }

    public override double GetPace()
    {
        if (_distanceMiles <= 0.0)
        {
            return 0.0;
        }
        double minutes = GetMinutes();
        return minutes / _distanceMiles;
    }
}
