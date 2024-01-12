using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int userGuess;
            int attempts = 0;

            do
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                attempts++;

                if (magicNumber == userGuess)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You made {attempts} attempts to guess.");
                    Console.WriteLine("");
                    Console.Write("Do you want to play again? (yes/no): ");
                    string userAnswer = Console.ReadLine();
                    if (userAnswer.ToLower() == "no")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Game Over.");
                        return;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (magicNumber > userGuess)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }
            } while (magicNumber != userGuess);

        } while (true);
    }
}
