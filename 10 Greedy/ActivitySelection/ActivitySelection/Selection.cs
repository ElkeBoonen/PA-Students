using System;
using System.Collections.Generic;
using System.Text;

namespace ActivitySelection
{
    class Selection
    {
        List<Activity> Activities;

        public Selection(List<Activity> activities)
        {
            Activities = activities;
        }

        public string Select()
        {
            Activities.Sort();

            int current = 0;
            string s = Activities[current].Name + " ";
            for (int i = 1; i < Activities.Count; i++)
            {
                if (Activities[i].Start >= Activities[current].End)
                {
                    current = i;
                    s += Activities[current].Name + " ";

                }
            }
            return s;        
        }
    }
}
