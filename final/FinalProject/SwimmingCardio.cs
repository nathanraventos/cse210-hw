using System;

public class SwimmingCardio : Cardio
{
    private int _laps;
    private string _strokeType;
    private float _poolLength;

    public SwimmingCardio(string date, int duration, float distance, float pace, int laps, string strokeType, float poolLength)
    : base(date, duration, distance, pace)
    {
        _laps = laps;
        _strokeType = strokeType;
        _poolLength = poolLength;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Laps: {_laps}, Stroke: {_strokeType}, Pool Length: {_poolLength} m");
    }

    public override string GetWorkoutType()
    {
        return "Swimming Cardio";
    }

    public int GetLaps()
    {
        return _laps;
    }

    public string GetStrokeType()
    {
        return _strokeType;
    }

    public float GetPoolLength()
    {
        return _poolLength;
    }
}