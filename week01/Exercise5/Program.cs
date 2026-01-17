using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Squared Number Calculator!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter a number to be squared: ");
        string input = Console.ReadLine();
        while (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer: ");
            input = Console.ReadLine();
        }
        return int.Parse(input);
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is: {squaredNumber}");
    }
}