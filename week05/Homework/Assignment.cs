using System;

class Assignment
{
    private string studentName;
    private string assignmentTitle;
    public string GetStudentName()
    {
        return studentName;
    }

    public Assignment(string studentName, string assignmentTitle)
    {
        this.studentName = studentName;
        this.assignmentTitle = assignmentTitle;
    }

    public void GetSummary()
    {