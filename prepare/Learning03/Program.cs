using System;
using System.Security.Cryptography;

public class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(); ///this is default constructor in fraction.cs
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());



        Fraction s1 = new Fraction();

        s1.SetFractionNumer(2);
        s1.SetFractionDenom(3);
        Console.WriteLine(s1.GetFractionString());

    }
}