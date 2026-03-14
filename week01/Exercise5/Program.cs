using System;

class Program
{
    static void Main(string[] args)
    {
        // Call each function in order
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber);
    }

    // Function 1: Display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("I welcome you to this program!");
    }

    // Function 2: Ask for the user's name
    static string PromptUserName()
    {
        Console.Write("Kindly enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function 3: Ask for the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Kindly enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input); // convert string to int
        return number;
    }

    // Function 4: Square the number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function 5: Display the result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
