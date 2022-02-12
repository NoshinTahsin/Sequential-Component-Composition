using System;
using ClassLibraryResumeProvider;
using ClassLibraryInitialScreening;
using ClassLibraryFinalAssessment;

namespace RecruitmentSequentialComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            IResumeProvider resumeProvider = new ResumeProvider();
            IInitialScreening initialScreening = new InitialScreening();
            IFinalAssessment finalAssessment = new FinalAssessment();

            Console.WriteLine("Demonstrating Sequential Component Composition\n");

            String allResumeList = resumeProvider.provideResume();
            Console.WriteLine("<"+allResumeList+"> returned\n");
            String selectedResumeList = initialScreening.provideSelected(allResumeList);
            Console.WriteLine("<"+selectedResumeList + "> returned\n");
            String finalAcceptanceList = finalAssessment.acceptanceList(selectedResumeList);
            Console.WriteLine("<"+finalAcceptanceList + "> returned\n");

        }
    }
}
