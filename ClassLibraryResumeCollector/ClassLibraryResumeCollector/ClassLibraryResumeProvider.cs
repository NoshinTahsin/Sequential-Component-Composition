using System;

//created a c# class library
//interface for resume provider class
namespace ClassLibraryResumeProvider
{
    public class ResumeProvider: IResumeProvider
    {
        public String provideResume() {

            return "Returned list of collected resumes.";
            
        }

    }
}
