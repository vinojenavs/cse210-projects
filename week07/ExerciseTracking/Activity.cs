using System;

public class Activity
{
    private DateTime _date;
    private int _lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime GetDate() => _date;
    public int GetLengthMinutes() => _lengthMinutes;

    public virtual double GetDistance()
    {
        throw new NotImplementedException("GetDistance must be overridden.");
    }

    public virtual double GetSpeed()
    {
        throw new NotImplementedException("GetSpeed must be overridden.");
    }

    public virtual double GetPace()
    {
        throw new NotImplementedException("GetPace must be overridden.");
    }

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_lengthMinutes} min) - " +
               $"Distance: {GetDistance():0.00} miles, Speed: {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min per mile";
    }
}
