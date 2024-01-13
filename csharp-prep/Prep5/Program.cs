using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Welcome();
        string userName = Name();
        int userNumber = Number();
        int squareNumber = Square(userNumber);
        Message(userName, squareNumber);
    }

    static void Welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string Name()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int Number()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int Square(int userNumber)
    {
        int squareNumber = userNumber * userNumber;
        return squareNumber;
    }

    static void Message(string userName, int SquareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {SquareNumber}");
    }
}