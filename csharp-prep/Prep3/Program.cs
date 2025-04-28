using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.WriteLine("The magic number has been chosen!");
       
       int userGuess = -1;
       int numberOfGuesses = 0;

       while(userGuess != magicNumber)
       {
        Console.Write("What is your guess: ");
        userGuess = int.Parse(Console.ReadLine());

        if(userGuess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if(userGuess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        numberOfGuesses += 1;
       }
       Console.WriteLine("You've done it bro!");
       Console.WriteLine($"It took you {numberOfGuesses} guesses");
        
    }
}