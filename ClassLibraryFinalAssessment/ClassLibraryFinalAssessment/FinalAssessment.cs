using System;

namespace ClassLibraryFinalAssessment
{
    public class FinalAssessment:IFinalAssessment
    {
        public String acceptanceList(String selectedResumeList)
        {
            return "Acceptance list after final assessment of the " + selectedResumeList;
        }
    }
}
