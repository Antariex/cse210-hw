using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userInput;
        int sum = 0;
        double average = 0;
        int largest = 0;
        int smallest = 0;
        List<int> sorted = new List<int>();

        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                userNumbers.Add(userInput);
                sum += userInput;
                average = (double)sum / userNumbers.Count;
                largest = userNumbers.Max();
                smallest = userNumbers.Where(numero => numero > 0).Min();
                sorted = new List<int>(userNumbers);
                sorted.Sort();
            }
        } while (userInput != 0);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        
        Console.WriteLine("The sorted list is:");
        foreach (var number in sorted)
        {
            Console.WriteLine(number);
        }
    }
}