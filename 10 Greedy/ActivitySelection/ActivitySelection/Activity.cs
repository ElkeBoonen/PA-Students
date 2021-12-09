using System;
using System.Collections.Generic;
using System.Text;

namespace ActivitySelection
{
    class Activity : IComparable
    {

        public double Start { get; set; }
        public double End { get; set; }
        public string Name { get; set; }

        public Activity(string name, double start, double end)
        {
            Name = name;
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return $"{Name}: {Start}-{End}";
        }

        public int CompareTo(object obj)
        {
            // 1 groter dan, 0 gelijk, -1 kleiner dan
            Activity a = this;
            Activity b = (Activity)obj;
            if (a.End > b.End) return 1;
            else if (a.End < b.End) return -1;
            else return 0;
        }
    }
}
