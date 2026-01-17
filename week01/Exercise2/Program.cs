using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        string name = Console.ReadLine();
        if (double.TryParse(name, out double grade))
        {
            if (grade >= 90)
            {
                Console.WriteLine("Your letter grade is: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your letter grade is: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your letter grade is: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your letter grade is: D");
            }
            else
            {
                Console.WriteLine("Your letter grade is: F");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric grade percentage.");
        }

        Console.WriteLine($"Your grade is {grade}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course. Better luck next time!");
        }

    }
}