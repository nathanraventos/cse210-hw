using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private List<string> _badges;
    public int GetLevel()
    {
        return (_score / 500) + 1;
    }

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _badges = new List<string>();
    }

    public int GetScore()
    {
        return _score;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].Display();
        }
    }

    public void RecordEvent(int goalIndex)
    {
        int pointsEarned = _goals[goalIndex].RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"You earned {pointsEarned} points!");
        CheckForBadges();
    }

    public void ShowScore()
    {
        Console.WriteLine($"\nCurrent Score: {_score} points");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                g.SetComplete(bool.Parse(data[3]));
                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal g = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
                g.SetTimesCompleted(int.Parse(data[5]));
                _goals.Add(g);
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }

    public int GetGoalCount()
    {
        return _goals.Count;
    }

    private void CheckForBadges()
    {
        if (_score >= 1000 && !_badges.Contains("Goal Master"))
        {
            _badges.Add("Goal Master");
            Console.WriteLine("🏆 New Badge Earned: Goal Master!");
        }

        int simpleGoalsCompleted = _goals.OfType<SimpleGoal>().Count(g => g.IsComplete());
        if (simpleGoalsCompleted >= 5 && !_badges.Contains("Task Slayer"))
        {
            _badges.Add("Task Slayer");
            Console.WriteLine("🏆 New Badge Earned: Task Slayer!");
        }

        int checklistsCompleted = _goals.OfType<ChecklistGoal>().Count(g => g.GetTimesCompleted() >= g.GetTargetCount());
        if (checklistsCompleted >= 3 && !_badges.Contains("Checklist Champion"))
        {
            _badges.Add("Checklist Champion");
            Console.WriteLine("🏆 New Badge Earned: Checklist Champion!");
        }
    }

    public void ShowStats()
    {
        int total = _goals.Count;
        int completed = _goals.OfType<SimpleGoal>().Count(g => g.IsComplete())
                    + _goals.OfType<ChecklistGoal>().Count(g => g.GetTimesCompleted() >= g.GetTargetCount());
        int remaining = total - completed;
        double percent = total > 0 ? (double)completed / total * 100 : 0;

        Console.WriteLine("\n--- Goal Stats ---");
        Console.WriteLine($"Total Goals: {total}");
        Console.WriteLine($"Goals Completed: {completed}");
        Console.WriteLine($"Goals Remaining: {remaining}");
        Console.WriteLine($"Completion Percentage: {percent:0.0}%");
    }

    public void ShowBadges() {
        if (_badges.Count == 0) {
            Console.WriteLine("\nNo badges earned yet.");
            return;
        }

        Console.WriteLine("\n🏅 Badges Earned:");
        foreach (string badge in _badges) {
            Console.WriteLine($"- {badge}");
        }
    }
}
