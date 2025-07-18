using System;

public class BodyweightStrength : Strength
{
    private string _difficultyLevel;
    private bool _isIsometric;
    private int _holdTime;

    public BodyweightStrength(string date, int duration, int sets, int reps, string exerciseName,
        string difficultyLevel, bool isIsometric, int holdTime)
        : base(date, duration, sets, reps, exerciseName)
    {
        _difficultyLevel = difficultyLevel;
        _isIsometric = isIsometric;
        _holdTime = holdTime;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Difficulty: {_difficultyLevel}, Isometric: {_isIsometric}, Hold Time: {_holdTime} sec");
    }

    public override string GetWorkoutType()
    {
        return "Bodyweight Strength";
    }

    public string GetDifficultyLevel()
    {
        return _difficultyLevel;
    }

    public bool GetIsIsometric()
    {
        return _isIsometric;
    }

    public int GetHoldTime()
    {
        return _holdTime;
    }
}
