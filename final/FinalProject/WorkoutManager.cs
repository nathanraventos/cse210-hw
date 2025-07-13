using System;
using System.Collections.Generic;

public class WorkoutManager
{
    private List<Workout> _workoutList;

    public WorkoutManager()
    {
        _workoutList = new List<Workout>();
    }

    public void AddWorkout()
    {
        // For now: just add a dummy EnduranceCardio to test
        Workout newWorkout = new EnduranceCardio("2025-07-12", 45, 10, 5, 60, 140);
        _workoutList.Add(newWorkout);
        Console.WriteLine("Workout added.");
    }

    public void ShowHistory()
    {
        if (_workoutList.Count == 0)
        {
            Console.WriteLine("No workouts logged yet.");
        }
        else
        {
            foreach (Workout workout in _workoutList)
            {
                workout.DisplayDetails();
                Console.WriteLine(); // spacing
            }
        }
    }

    public void SaveWorkout()
    {
        // Placeholder
    }

    public void ShowStats()
    {
        // Placeholder
    }
}
