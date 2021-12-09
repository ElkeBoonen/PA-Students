using System;
using System.Collections.Generic;
using System.Text;

namespace ActivitySelection___DSPS
{
    class Activity : IComparable
    {
        public string Name { get; set; }
        public double Start { get; set; }
        public double End { get; set; }

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

        //1 > greater, 0 equal, -1 < smaller
        public int CompareTo(object obj)
        {
            Activity a = this;
            Activity b = (Activity)obj;
            if (a.End < b.End) return -1;
            else if (a.End > b.End) return 1;
            else return 0;
        }
    }
}
