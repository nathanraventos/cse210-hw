using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        Reference ref1 = new Reference("John 3:16");
        Scripture s1 = new Scripture("For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.", ref1);

        Reference ref2 = new Reference("Proverbs 3:5-6");
        Scripture s2 = new Scripture("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.", ref2);

        Reference ref3 = new Reference("Philippians 4:13");
        Scripture s3 = new Scripture("I can do all this through him who gives me strength.", ref3);

        scriptures.Add(s1);
        scriptures.Add(s2);
        scriptures.Add(s3);

        Console.WriteLine("Which scripture would you like to practice?");

        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.Write($"{i + 1}: ");
            scriptures[i].Display();
            Console.WriteLine();
        }

        int selectedIndex;
        while (true)
        {
            Console.WriteLine("Enter the number of the scripture you want to practice:");
            string selectionInput = Console.ReadLine();
            if (int.TryParse(selectionInput, out selectedIndex) && selectedIndex >= 1 && selectedIndex <= scriptures.Count)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a number from the list.");
        }

        // Set the chosen scripture
        Scripture scripture = scriptures[selectedIndex - 1];

        Console.WriteLine("How many words would you like to hide each round?");
        int numberToHide;
        while (!int.TryParse(Console.ReadLine(), out numberToHide) || numberToHide < 1)
        {
            Console.WriteLine("Please enter a valid positive number.");
        }

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            Console.WriteLine("Press Enter to hide some words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (input == "")
            {
                scripture.HideSome(numberToHide);
            }
            else if (input.ToLower() == "reveal")
            {
                scripture.Reset();
            }
            else
            {
                Console.WriteLine("Invalid Input. Press Enter to continue");
                Console.ReadLine();
            }
        }

    }
    
}