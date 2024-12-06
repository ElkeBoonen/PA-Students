using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADI_Gredy
{
    internal class Lesson : IComparable<Lesson>
    {
        public string Name { get; set; }
        public double Start { get; set; }
        public double End { get; set; }

        public Lesson(string name, double start, double end)
        {
            Name = name;
            this.Start = start;
            this.End = end;
        }

        public int CompareTo(Lesson? other)
        {
            //return (int)(other.End - this.End);

            if (this.End < other.End) return -1;
            if (this.End > other.End) return 1;
            else return 0;
        }
    }
}
