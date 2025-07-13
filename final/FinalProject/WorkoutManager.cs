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
        Console.WriteLine("Choose workout type:");
        Console.WriteLine("1. Endurance Cardio");
        Console.WriteLine("2. Bodyweight Strength");
        Console.Write("Your choice: ");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter date (YYYY-MM-DD): ");
        string date = Console.ReadLine();

        Console.Write("Enter duration (minutes): ");
        int duration = int.Parse(Console.ReadLine());

        if (typeChoice == "1")
        {
            // Endurance Cardio details
            Console.Write("Enter distance (mi): ");
            float distance = float.Parse(Console.ReadLine());

            Console.Write("Enter pace (min/mi): ");
            float pace = float.Parse(Console.ReadLine());

            Console.Write("Enter target duration (min): ");
            int targetDuration = int.Parse(Console.ReadLine());

            Console.Write("Enter average heart rate (bpm): ");
            int avgHeartRate = int.Parse(Console.ReadLine());

            Workout newWorkout = new EnduranceCardio(date, duration, distance, pace, targetDuration, avgHeartRate);
            _workoutList.Add(newWorkout);
            Console.WriteLine("Workout added.");
        }
        else if (typeChoice == "2")
        {
            // Swimming Cardio
            Console.Write("Enter distance (km): ");
            float distance = float.Parse(Console.ReadLine());

            Console.Write("Enter pace (min/km): ");
            float pace = float.Parse(Console.ReadLine());

            Console.Write("Enter laps: ");
            int laps = int.Parse(Console.ReadLine());

            Console.Write("Enter stroke type: ");
            string strokeType = Console.ReadLine();

            Console.Write("Enter pool length (meters): ");
            float poolLength = float.Parse(Console.ReadLine());

            Workout newWorkout = new SwimmingCardio(date, duration, distance, pace, laps, strokeType, poolLength);
            _workoutList.Add(newWorkout);
            Console.WriteLine("Workout added.");
        }
        else if (typeChoice == "3")
        {
            // Bodyweight Strength details
            Console.Write("Enter exercise name: ");
            string exerciseName = Console.ReadLine();

            Console.Write("Enter sets: ");
            int sets = int.Parse(Console.ReadLine());

            Console.Write("Enter reps: ");
            int reps = int.Parse(Console.ReadLine());

            Console.Write("Enter difficulty level (easy, medium, hard): ");
            string difficulty = Console.ReadLine();

            Console.Write("Is this isometric? (true/false): ");
            bool isIsometric = bool.Parse(Console.ReadLine());

            Console.Write("Enter hold time (seconds): ");
            int holdTime = int.Parse(Console.ReadLine());

            Workout newWorkout = new BodyweightStrength(date, duration, sets, reps, exerciseName, difficulty, isIsometric, holdTime);
            _workoutList.Add(newWorkout);
            Console.WriteLine("Workout added.");
        }
        else if (typeChoice == "4")
        {
            // Weighted Strength
            Console.Write("Enter exercise name: ");
            string exerciseName = Console.ReadLine();

            Console.Write("Enter sets: ");
            int sets = int.Parse(Console.ReadLine());

            Console.Write("Enter reps: ");
            int reps = int.Parse(Console.ReadLine());

            Console.Write("Enter weight (kg): ");
            float weight = float.Parse(Console.ReadLine());

            Console.Write("Enter equipment name: ");
            string equipmentName = Console.ReadLine();

            Console.Write("Enter rest time (seconds): ");
            int restTime = int.Parse(Console.ReadLine());

            Workout newWorkout = new WeightedStrength(date, duration, sets, reps, exerciseName, weight, equipmentName, restTime);
            _workoutList.Add(newWorkout);
            Console.WriteLine("Workout added.");
        }
        else
        {
            Console.WriteLine("Invalid workout type selected.");
        }
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
