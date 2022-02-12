using System;

namespace ClassLibraryInitialScreening
{
    public class InitialScreening:IInitialScreening
    {
        public String provideSelected(String AllResumeList)
        {
            return "Provide selected resume list after initial screening of the " + AllResumeList;
        }
    }
}