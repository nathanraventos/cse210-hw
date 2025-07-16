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
        Console.WriteLine("2. Swimming Cardio");
        Console.WriteLine("3. Bodyweight Strength");
        Console.WriteLine("4. Weighted Strength");
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
            Console.Write("Enter distance (miles): ");
            float distance = float.Parse(Console.ReadLine());

            Console.Write("Enter pace (miles/min): ");
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

            Console.Write("Enter weight (lbs): ");
            float weight = float.Parse(Console.ReadLine());

            Console.Write("Enter rest time (seconds): ");
            int restTime = int.Parse(Console.ReadLine());

            Workout newWorkout = new WeightedStrength(date, duration, sets, reps, exerciseName, weight, restTime);
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
                Console.WriteLine($"\nWorkout Type: {workout.GetWorkoutType()}");
                workout.DisplayDetails();
            }
        }
    }

    public void SaveWorkout()
    {
        string fileName = "workouts.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Workout workout in _workoutList)
            {
                writer.WriteLine($"Workout Type: {workout.GetWorkoutType()}");
                writer.WriteLine($"Date: {workout.GetDate()}, Duration: {workout.GetDuration()} min");

                // Save extra details based on workout type
                if (workout is EnduranceCardio ec)
                {
                    writer.WriteLine($"Distance: {ec.GetDistance()} miles, Pace: {ec.GetPace()} min/mile");
                    writer.WriteLine($"Target Duration: {ec.GetTargetDuration()} min, Avg Heart Rate: {ec.GetAvgHeartRate()} bpm");
                }
                else if (workout is SwimmingCardio sc)
                {
                    writer.WriteLine($"Distance: {sc.GetDistance()} mile, Pace: {sc.GetPace()} min/mile");
                    writer.WriteLine($"Laps: {sc.GetLaps()}, Stroke: {sc.GetStrokeType()}, Pool Length: {sc.GetPoolLength()} m");
                }
                else if (workout is BodyweightStrength bs)
                {
                    writer.WriteLine($"Exercise: {bs.GetExerciseName()}, Sets: {bs.GetSets()}, Reps: {bs.GetReps()}");
                    writer.WriteLine($"Difficulty: {bs.GetDifficultyLevel()}, Isometric: {bs.GetIsIsometric()}, Hold Time: {bs.GetHoldTime()} sec");
                }
                else if (workout is WeightedStrength ws)
                {
                    writer.WriteLine($"Exercise: {ws.GetExerciseName()}, Sets: {ws.GetSets()}, Reps: {ws.GetReps()}");
                    writer.WriteLine($"Weight: {ws.GetWeight()} lbs, Rest Time: {ws.GetRestTime()} sec");
                }

                writer.WriteLine(); // blank line between workouts
            }
        }

        Console.WriteLine("Workouts saved to workouts.txt");
    }
    
    public void LoadWorkouts()
    {
        string fileName = "workouts.txt";

        if (File.Exists(fileName))
        {
            Console.WriteLine($"\nContents of {fileName}:\n");
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("No saved workout file found.");
        }
    }
}
