using System;
using System.Collections.Generic;

namespace ActivitySelection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> list = new List<Activity>();
            list.Add(new Activity("math", 10, 11));
            list.Add(new Activity("eng", 9.5, 10.5));
            list.Add(new Activity("music", 11, 12));
            list.Add(new Activity("art", 9, 10));
            list.Add(new Activity("cs", 10.5, 11.5));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Selection selection = new Selection(list);
            Console.WriteLine(selection.Select());
        }
    }
}
