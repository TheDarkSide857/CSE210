using System;

class WritingAssignment : Assignment
{
    private string topic;

    public WritingAssignment(string studentName, string assignmentTitle, string topic)
        : base(studentName, assignmentTitle)
    {
        this.topic = topic;
    }

    public void GetWritingInformation()
    {
        string studentName = GetStudentName();
        Console.WriteLine($"{topic} by {studentName}");
    }
}