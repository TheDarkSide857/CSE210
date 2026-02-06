using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");

        assignment.GetSummary();

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        mathAssignment.GetSummary();
        mathAssignment.GetHomeworkList();

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        writingAssignment.GetSummary();
        writingAssignment.GetWritingInformation();
    }
}