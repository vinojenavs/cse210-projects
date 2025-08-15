public class Running : Activity
{
    private double _distanceMiles;

    public Running(DateTime date, int lengthMinutes, double distanceMiles)
        : base(date, lengthMinutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance() => _distanceMiles;

    public override double GetSpeed() => (_distanceMiles / GetLengthMinutes()) * 60;

    public override double GetPace() => GetLengthMinutes() / _distanceMiles;
}
