using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their name.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Ask the user for their lastname.
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Add a blank line.
        Console.WriteLine();
        
        // Print the message to the user.
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}