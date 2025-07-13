using System;

public class Strength : Workout
{
    private int _sets;
    private int _reps;
    private string _exerciseName;

    public Strength(string date, int duration, int sets, int reps, string exerciseName)
    : base(date, duration)
    {
        _sets = sets;
        _reps = reps;
        _exerciseName = exerciseName;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Exercise: {_exerciseName}, Sets: {_sets}, Reps: {_reps}");
    }

    public int GetSets() => _sets;
    public int GetReps() => _reps;
    public string GetExerciseName() => _exerciseName;
}

