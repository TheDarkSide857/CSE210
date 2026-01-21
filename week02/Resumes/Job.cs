using System;

class Job
{
    static void Main(string[] args)
    {
        public string _jobTitle;
        public string _company;
        public string _startDate;
        public string _endDate;
        public void Display()
        {
            Console.WriteLine(_jobTitle);
            Console.WriteLine(_company);
            Console.WriteLine(_startDate + " - " + _endDate);
            Console.WriteLine();
        }
    }
}