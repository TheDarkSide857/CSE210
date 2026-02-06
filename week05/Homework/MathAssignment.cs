using System;

class MathAssignment : Assignment
{
    private string textbookSection;
    private string problems;

    public MathAssignment(string studentName, string assignmentTitle, string textbookSection, string problems)
        : base(studentName, assignmentTitle)
    {
        this.textbookSection = textbookSection;
        this.problems = problems;
    }

    public void GetHomeworkList()
    {
        Console.WriteLine($"Section {textbookSection} Problems {problems}");
    }
}