using System;
using System.Collections.Generic;
List<int> numbers = new List<int>();
int userNumber = -1;

while (userNumber != 0)
{
    Console.WriteLine("Please enter the number you want on the list: ");
    userNumber = int.Parse(Console.ReadLine());
    if (userNumber != 0)
    {
        numbers.Add(userNumber);
    }

}
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine($"The sum of this list is: {sum}");

double average = (double)sum / numbers.Count;
Console.WriteLine($"The average of the list is: {average}");

int largestNumber = numbers[0];
foreach (int number in numbers)
{
    if (number > largestNumber)
    {
        largestNumber = number;
    }
}
Console.WriteLine($"The largest number is : {largestNumber}");
