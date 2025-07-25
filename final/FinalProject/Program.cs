using System;

class Program
{
    static void Main(string[] args)
    {
        WorkoutManager manager = new WorkoutManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nWorkout Tracker");
            Console.WriteLine("1. Add Workout");
            Console.WriteLine("2. Show History");
            Console.WriteLine("3. Save Workouts");
            Console.WriteLine("4. Load Workouts");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.AddWorkout();
                    break;
                case "2":
                    manager.ShowHistory();
                    break;
                case "3":
                    manager.SaveWorkout();
                    break;
                    case "4":
                    manager.LoadWorkouts();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
