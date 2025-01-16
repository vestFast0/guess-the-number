using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Guess the number!");

        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Generates a number between 1 and 100

        while (true)
        {
            Console.WriteLine("Please input your guess.");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out int guess))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            Console.WriteLine($"You guessed: {guess}");

            if (guess < secretNumber)
            {
                Console.WriteLine("Too small!");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too big!");
            }
            else
            {
                Console.WriteLine("You win!");
                break;
            }
        }
    }
}