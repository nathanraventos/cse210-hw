using System;

public class Workout
{
    private string _date;
    private int _duration;

    public Workout(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Date: {_date}, Duration: {_duration} mins");
    }

    public string GetDate() => _date;
    public int GetDuration() => _duration;
}