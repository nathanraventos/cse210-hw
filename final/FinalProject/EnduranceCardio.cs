using System;

public class EnduranceCardio : Cardio
{
    private int _targetDuration;
    private int _avgHeartRate;

    public EnduranceCardio(string date, int duration, float distance, float pace, int targetDuration, int avgHeartRate)
    : base(date, duration, distance, pace)
    {
        _targetDuration = targetDuration;
        _avgHeartRate = avgHeartRate;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Target Duration: {_targetDuration} min, Avg Heart Rate: {_avgHeartRate} bpm");
    }

    public int GetTargetDuration() => _targetDuration;
    public int GetAvgHeartRate() => _avgHeartRate;
}