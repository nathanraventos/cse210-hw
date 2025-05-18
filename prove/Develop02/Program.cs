using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>
        {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?"
        };

        Journal journal = new Journal();
        Random random = new Random();
        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit"); 

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine(prompt);

            Console.Write("Your response: ");
            string response = Console.ReadLine();

            string date = DateTime.Now.ToShortDateString();
            Entry entry = new Entry(date, prompt, response);
            journal.AddEntry(entry);
            }    

            else if (choice == 2) 
            {
                journal.DisplayAllEntries();
            }

            else if (choice == 3)
            {
                Console.Write("Enter a filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (choice == 4)
            {
                Console.Write("Enter a filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }
    }
}