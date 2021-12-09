using System;
using System.Collections.Generic;

namespace ActivitySelection___DSPS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();
            activities.Add(new Activity("CS", 10.5, 11.5));
            activities.Add(new Activity("ENG", 9.5, 10.5));
            activities.Add(new Activity("MATH", 10, 11));
            activities.Add(new Activity("MUSIC", 11, 12));
            activities.Add(new Activity("ART", 9, 10));

            foreach (var item in activities)
            {
                Console.WriteLine(item);
            }

            Selection selection = new Selection(activities);
            Console.WriteLine("\nSELECTED COURSES");
            foreach (var item in selection.Greedy())
            {
                Console.WriteLine(item);
            }

        }
    }
}


/* For Abdul ;)
string s = "A: U B I";
string[] array = s.Split(new char[] { ':', ' '});
foreach (var item in array)
{
    Console.WriteLine("*" + item + "*");
}*/
