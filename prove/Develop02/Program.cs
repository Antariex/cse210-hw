using System;
using System.Collections.Generic;

class Program
{
    public class Prompts
    {
        private List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        public string RandomPrompt()
        {
            Random random = new Random();
            int randomIndex = random.Next(_prompts.Count);
            return _prompts[randomIndex];
        }
    }

    public class Entry
    {
        private string _date;
        private string _prompt;
        private string _entryText;

        public void Display()
        {
            Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nEntry Text: {_entryText}");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Write();
                    break;
                case "2":
  //                  DisplayEntry();
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

    public static void Write()
    {
        Prompts prompts = new Prompts();
        string randomPrompt = prompts.RandomPrompt();
        Console.WriteLine(randomPrompt);

        Console.Write("> ");
        string userEntry = Console.ReadLine();
    }

  }
