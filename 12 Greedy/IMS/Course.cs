using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public class Course : IComparable<Course>
    {
        public double Start { get; set; }
        public double End { get; set; }

        public string Name { get; set; }

        public Course(string name, double start, double end)
        {
            Start = start;
            End = end;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} {Start}:{End}";
        }

        public int CompareTo(Course other)
        {
            if (this.End < other.End) return -1;
            if (this.End > other.End) return 1;
            return 0;
        }
    }
}
