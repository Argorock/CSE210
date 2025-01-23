using System;
using System.ComponentModel.DataAnnotations;

class Abstraction 
{
    static void Main()
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear =2020;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear =2025;

        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        Console.Write("What is your name: ");
        resume._name = Console.ReadLine();
        
        resume.DisplayResume();
        
    }


}