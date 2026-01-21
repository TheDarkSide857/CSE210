using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Gumball Filler";
        job1._company = "Macy's";
        job1._startDate = "January 2018";
        job1._endDate = "January 2022";
        job1.Display();

        Job job2 = new Job();
        job1._jobTitle = "Chocolate Box Filler";
        job1._company = "Lula's Chocolates";
        job1._startDate = "January 2022";
        job1._endDate = "Present";
        job1.Display();

        Resume myResume = new Resume();
        myResume._name = "Dallin Stewart";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        
    }
}