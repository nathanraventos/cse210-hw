using System;

class Program {
    static void Main(string[] args) {
        GoalManager manager = new GoalManager();
        int choice = 0;

        while (choice != 8)
        {
            Console.WriteLine($"\nCurrent Score: {manager.GetScore()} points (Level {manager.GetLevel()})");
            Console.WriteLine("\n--- Eternal Quest Menu ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. View Stats");
            Console.WriteLine("7. View Badges");
            Console.WriteLine("8. Quit");

            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                Console.Write("Choose goal type: ");
                int type = int.Parse(Console.ReadLine());

                Console.Write("Enter goal name: ");
                string name = Console.ReadLine();

                Console.Write("Enter goal description: ");
                string description = Console.ReadLine();

                Console.Write("Enter point value: ");
                int points = int.Parse(Console.ReadLine());

                if (type == 1)
                {
                    manager.AddGoal(new SimpleGoal(name, description, points));
                }
                else if (type == 2)
                {
                    manager.AddGoal(new EternalGoal(name, description, points));
                }
                else if (type == 3)
                {
                    Console.Write("Enter target count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Enter bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                }
            }
            else if (choice == 2) manager.DisplayGoals();
            else if (choice == 3) manager.SaveGoals("goals.txt");
            else if (choice == 4) manager.LoadGoals("goals.txt");
            else if (choice == 5)
            {
                manager.DisplayGoals();
                Console.Write("Which goal did you accomplish? (enter number) ");
                int goalIndex = int.Parse(Console.ReadLine()) - 1;
                manager.RecordEvent(goalIndex);
            }
            else if (choice == 6) manager.ShowStats();
            else if (choice == 7) manager.ShowBadges();
        }
    }
}
