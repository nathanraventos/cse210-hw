public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    : base(name, description, points)
    { }

   public override void Display() {
        Console.WriteLine($"[∞] {GetName()}: {GetDescription()}");
    }

    public override string GetStringRepresentation() {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}