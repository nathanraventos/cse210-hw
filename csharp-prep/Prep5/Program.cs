using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
       Console.WriteLine("hat's your favorite number? ");
       int favoriteNumber = int.Parse(Console.ReadLine());
       return favoriteNumber;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"Hey {userName}, the square of your favorite number is {squaredNumber}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int favoriteNum = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNum);

        DisplayResult(name, squaredNumber);

    }
}
