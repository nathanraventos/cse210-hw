using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("What is your grade percentage? ");
        string userAnswer = Console.ReadLine();
        int userGrade = int.Parse(userAnswer);

        string letterGrade = "";
        string gradeSign = "";

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

        if (userGrade % 10 >= 7)
        {
           gradeSign = "+";
        }
        else if (userGrade % 10 <3)
        {
            gradeSign = "-";
        }

        if (letterGrade == "A" && gradeSign == "+" || letterGrade == "F" && gradeSign == "+" || gradeSign == "-")
        {
            Console.WriteLine($"You recieved a {letterGrade} for this class.");
        }
        else
        {
             Console.WriteLine($"You recieved a {letterGrade}{gradeSign} for this class.");
        }

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