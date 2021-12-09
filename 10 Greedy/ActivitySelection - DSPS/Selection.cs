using System;
using System.Collections.Generic;
using System.Text;

namespace ActivitySelection___DSPS
{
    class Selection
    {
        public List<Activity> Activities { get; set; }

        public Selection()
        {
            Activities = new List<Activity>();
        }
        public Selection(List<Activity> activities)
        {
            Activities = activities;
        }

        public List<Activity> Greedy()
        {
            List<Activity> selected = new List<Activity>();
            Activities.Sort();

            int current = 0;
            selected.Add(Activities[current]);
            for (int i = 1; i < Activities.Count; i++)
            {
                if (Activities[i].Start >= Activities[current].End)
                {
                    selected.Add(Activities[i]);
                    current = i;
                }
            }
            return selected;
        }
       
    }
}
