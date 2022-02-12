using System;

namespace ClassLibraryInitialScreening
{
    public class InitialScreening:IInitialScreening
    {
        public String provideSelected(String AllResumeList)
        {
            String selectedResumeList = "Selected Resume List";
            Console.WriteLine("Providing selected resume list after initial screening of the " + AllResumeList+"...");
            return selectedResumeList;
        }
    }
}