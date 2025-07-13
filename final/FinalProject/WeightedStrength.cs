using System;

public class WeightedStrength : Strength
{
    private float _weight;
    private string _equipmentName;
    private int _restTime;

    public WeightedStrength(string date, int duration, int sets, int reps, string exerciseName,
        float weight, string equipmentName, int restTime)
        : base(date, duration, sets, reps, exerciseName)
    {
        _weight = weight;
        _equipmentName = equipmentName;
        _restTime = restTime;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Weight: {_weight} kg, Equipment: {_equipmentName}, Rest Time: {_restTime} sec");
    }

    public float GetWeight() => _weight;
    public string GetEquipmentName() => _equipmentName;
    public int GetRestTime() => _restTime;
}
