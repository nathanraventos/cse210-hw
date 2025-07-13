using System;
public class Cardio : Workout
{
    private float _distance;
    private float _pace;

    public Cardio(string date, int duration, float distance, float pace)
    : base(date, duration)
    {
        _distance = distance;
        _pace = pace;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Distance: {_distance} miles, Pace: {_pace} min/mile");
    }

    public float GetDistance()
    {
        return _distance;
    }

    public float GetPace()
    {
        return _pace;
    }
}