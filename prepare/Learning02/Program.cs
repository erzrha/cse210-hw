using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Head IT";
        job1._company = "Microsoft";
        job1._startYear = 2000;
        job1._endYear = 2017;
        

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2017;
        job2._endYear = 2020;
        
        Resume my_Resume = new Resume(); 
        my_Resume._jobs.Add(job1);
        my_Resume._jobs.Add(job2);
        my_Resume.DisplayResume();
        
    }
}