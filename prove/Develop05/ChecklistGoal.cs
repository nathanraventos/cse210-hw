public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _timesCompleted;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
    : base(name, description, points)
    {
        _targetCount = targetCount;
        _timesCompleted = 0;
        _bonusPoints = bonusPoints;
    }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    public void SetTimesCompleted(int count)
    {
        _timesCompleted = count;
    }

    public int GetTargetCount()
    {
        return _targetCount;
    }

    public void SetTargetCount(int count)
    {
        _targetCount = count;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public void SetBonusPoints(int bonus)
    {
        _bonusPoints = bonus;
    }

    public override int RecordEvent() {
        _timesCompleted++;
        if (_timesCompleted == _targetCount) {
            return GetPoints() + _bonusPoints;
        }
        return GetPoints();
    }

    public override void Display() {
        string status = _timesCompleted >= _targetCount ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {GetName()}: {GetDescription()} — Completed {_timesCompleted}/{_targetCount} times");
    }

    public override string GetStringRepresentation() {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_targetCount},{_bonusPoints},{_timesCompleted}";
    }


}