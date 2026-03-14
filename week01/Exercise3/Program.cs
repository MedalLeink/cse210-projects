using System;

class Program
{
    static void Main(string[] args)
    {
        Random generateRandomly = new Random();
        int magicNumber = generateRandomly.Next(1, 101);

        int guess = -1;
        int guessCounter = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your preferred guess? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            guessCounter++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it right!");
                Console.WriteLine($"It took you {guessCounter} guesses to get to the magic number!");
            }
        }
    }
}