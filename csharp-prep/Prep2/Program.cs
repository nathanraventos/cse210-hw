using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for the user's grade percentage
        Console.WriteLine("What is your grade percentage? ");
        string userAnswer = Console.ReadLine();
        int userGrade = int.Parse(userAnswer);

        // Initialize variables for letter grade and grade sign
        string letterGrade = "";
        string gradeSign = "";

        // Determine the letter grade based on the user's percentage
        if (userGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (userGrade < 90 && userGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (userGrade < 80 && userGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (userGrade < 70 && userGrade >= 60)
        {
            letterGrade = "D";
        }
        else if (userGrade < 60)
        {
            letterGrade = "F";
        }

         // Determine the grade sign (+ or -) based on the last digit of the grade
        if (userGrade % 10 >= 7)
        {
           gradeSign = "+";
        }
        else if (userGrade % 10 <3)
        {
            gradeSign = "-";
        }

        // Print the grade, handling the exception for "A+" or "F+" which are not allowed
        if (letterGrade == "A" && gradeSign == "+" || letterGrade == "F" && gradeSign == "+" || gradeSign == "-")
        {
            Console.WriteLine($"You recieved a {letterGrade} for this class.");
        }
        else
        {
             Console.WriteLine($"You recieved a {letterGrade}{gradeSign} for this class.");
        }

        // Provide a passing or failing message
        if (userGrade >= 70)
        {
            Console.WriteLine("You passed the class! Absolute Legend!");
        }
        else
        {
            Console.WriteLine("You failed, but you got it next time!");
        }
    }
}