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

        public List<Course> Create()
        {
            List<Course> schedule = new List<Course>();

            Courses.Sort();
            schedule.Add(Courses[0]);
            for (int i = 1; i < Courses.Count; i++)
            {
                if (Courses[i].Start >= schedule.Last().End)
                { 
                    schedule.Add(Courses[i]);
                }
            }

            return schedule;
        }
    }
}
