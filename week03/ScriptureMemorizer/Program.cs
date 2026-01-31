// I exceeded the core by making sure the program only hides words that are not already hidden by checking and skipping words that are already hidden.
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetText());
        Console.WriteLine("All words are hidden. Well done!");
    }
}