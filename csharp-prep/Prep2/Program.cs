using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Please, enter your grade percentage: ");
        int userGrade = int.Parse(Console.ReadLine());
        string letter;
        string sign = "";

        // Print the grade letter
        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80 && userGrade < 90)
        {
            letter = "B";
        }
        else if (userGrade >= 70 && userGrade < 80)
        {
            letter = "C";
        }
        else if (userGrade >= 60 && userGrade < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign based on the last digit and handle A+ cases
        int lastDigit = userGrade % 10;
        if (lastDigit >= 7 && userGrade <= 93)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Concatenate the letter grade and sign and handle F cases
        string finalGrade = letter + sign;

        if (userGrade >= 60)
        {
            Console.WriteLine($"Your grade is {finalGrade}");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}");
        }

        // Print message to the user
        if (userGrade >= 70)
        {
            Console.WriteLine("Congratulations, you pass the class!");
        }
        else
        {
            Console.WriteLine("Sadly, you don't pass the class. Try harder next time!");
        }
    }
}