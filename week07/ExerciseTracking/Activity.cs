using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    protected Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        string dateString = _date.ToString("dd MMM yyyy");
        string name = this.GetType().Name;
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

        string distanceStr = distance.ToString("0.0");
        string speedStr = speed.ToString("0.0");
        string paceStr = pace.ToString("0.00");

        return dateString + " " + name + " (" + _minutes + " min) - Distance " + distanceStr + " miles, Speed " + speedStr + " mph, Pace: " + paceStr + " min per mile";
    }
}
