public class Swimming : Activity
{
    public double Distance { get; private set; }

    public Swimming(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        
        return LengthInMinutes == 0 ? 0 : (Distance / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        
        return Distance == 0 ? 0 : LengthInMinutes / Distance;
    }
}
