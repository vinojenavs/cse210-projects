public class Cycling : Activity
{
    private double _speedMph;

    public Cycling(DateTime date, int lengthMinutes, double speedMph)
        : base(date, lengthMinutes)
    {
        _speedMph = speedMph;
    }

    public override double GetDistance() => (_speedMph * GetLengthMinutes()) / 60;

    public override double GetSpeed() => _speedMph;

    public override double GetPace() => 60 / _speedMph;
}
