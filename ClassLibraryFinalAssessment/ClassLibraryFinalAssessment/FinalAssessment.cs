using System;

namespace ClassLibraryFinalAssessment
{
    public class FinalAssessment:IFinalAssessment
    {
        public String acceptanceList(String selectedResumeList)
        {
            String acceptedResumeList = "Final Accepted Resume List";
            Console.WriteLine("Providing acceptance list after final assessment of the "+selectedResumeList+"...");
            return acceptedResumeList;
        }
    }
}
