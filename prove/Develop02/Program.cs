using System;
using System.Collections.Generic;

class Program
{




    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Entry newEntry = new Entry();
                    journal.AddEntry(newEntry);
                    

                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("You chose to Load. Add your load logic here.");
                    break;
                case "4":
                    Console.WriteLine("You chose to Save. Add your save logic here.");
                    break;
                case "5":
                    Console.WriteLine("Quitting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
