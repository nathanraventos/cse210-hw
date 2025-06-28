public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    : base(name, description, points)
    {
        _isComplete = false;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    public override void Display()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {GetName()}: {GetDescription()}");
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }

}