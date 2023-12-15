using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    public class Schedule
    {
        public List<Course> Courses { get; set; }

        public Schedule(List<Course> courses)
        {
            Courses = courses;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Course item in Courses)
            {
                s += item + "\n";
            }
            return s;
        }
    }
}
