using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int input = -1;
        while (input != magicNumber)
        {
            Console.WriteLine("What is the magic number?");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out input))
            {
                if (input == magicNumber)
                {
                    Console.WriteLine("Congratulations! You've guessed the magic number!");
                }
                else if (input < magicNumber)
                {
                    Console.WriteLine("Try to go higher.");
                }
                else if (input > magicNumber)
                {
                    Console.WriteLine("Try to go lower.");
                }
                else if (input <= 0 || input > 100)
                {
                    Console.WriteLine("Please enter a number between 1 and 10.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }
        }
    }
}