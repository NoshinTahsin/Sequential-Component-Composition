using System;

//created a c# class library
//interface for resume provider class
namespace ClassLibraryResumeProvider
{
    public class ResumeProvider : IResumeProvider
    {
        public String provideResume()
        {
            String allResumeList = "All Collected Resumes";
            Console.WriteLine("Providing list of "+allResumeList+"...");
            return allResumeList;

        }

    }
}