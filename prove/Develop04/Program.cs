using System;


class Program
{
    static void Main(string[] args)
    {
        List<string> activityLog = new List<string>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Stretching Activity");
            Console.WriteLine("5. View Activity Log");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                var activity = new BreathingActivity();
                activity.Run();
                activityLog.Add($"{DateTime.Now}: Completed {activity.GetName()} for {activity.GetDuration()} seconds.");
            }
            else if (choice == "2")
            {
                var activity = new ReflectionActivity();
                activity.Run();
                activityLog.Add($"{DateTime.Now}: Completed {activity.GetName()} for {activity.GetDuration()} seconds.");
            }
            else if (choice == "3")
            {
                var activity = new ListingActivity();
                activity.Run();
                activityLog.Add($"{DateTime.Now}: Completed {activity.GetName()} for {activity.GetDuration()} seconds.");
            }
            else if (choice == "4")
            {
                var activity = new StretchingActivity();
                activity.Run();
                activityLog.Add($"{DateTime.Now}: Completed {activity.GetName()} for {activity.GetDuration()} seconds.");
            }
            else if (choice == "5")
            {
                Console.Clear();
                Console.WriteLine("Activity Log:\n");
                if (activityLog.Count == 0)
                {
                    Console.WriteLine("No activities completed yet.");
                }
                else
                {
                    foreach (var log in activityLog)
                    {
                        Console.WriteLine(log);
                    }
                }

                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }

            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
        }
    }
}
