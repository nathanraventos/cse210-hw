using System;

public class WeightedStrength : Strength
{
    private float _weight;
    private int _restTime;

    public WeightedStrength(string date, int duration, int sets, int reps, string exerciseName,
        float weight, int restTime)
        : base(date, duration, sets, reps, exerciseName)
    {
        _weight = weight;
        _restTime = restTime;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Weight: {_weight} lbs, Rest Time: {_restTime} sec");
    }

    public override string GetWorkoutType()
    {
        return "Weighted Strength";
    }

    public float GetWeight()
    {
        return _weight;
    }

    public int GetRestTime()
    {
        return _restTime;
    }
}
