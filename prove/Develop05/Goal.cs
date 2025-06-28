using System.ComponentModel;

public class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public virtual int RecordEvent()
    {
        return _points;
    }

    public virtual void Display()
    {
        Console.WriteLine($"{_name}: {_description}");
    }

    public virtual string GetStringRepresentation()
    {
        return $"Goal:{_name},{_description},{_points}";
    }
}