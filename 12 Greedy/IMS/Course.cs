using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public class Course
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
    }
}
