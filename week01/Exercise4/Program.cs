using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter numbers one by one. Type '0' when you are finished:");
        int input = -1;
        while (input != 0)
        {
            Console.WriteLine("Enter a number:");

            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out input))
            {
                if (input != 0)
                {
                    numbers.Add(input);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the entered numbers is: {sum}");
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average of the entered numbers is: {average}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum number entered is: {max}");
    }
}