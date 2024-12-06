using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADI_Gredy
{
    internal class Schedule
    {
        public List<Lesson> Lessons { get; set; }

        public Schedule()
        {
            Lessons = new List<Lesson>();
        }

        public List<Lesson> Make()
        { 
            
        }

        public override string ToString()
        {
            string s = "";
            foreach (Lesson lesson in Lessons)
            { 
                s += lesson.Name + " (" + lesson.Start + ":" + lesson.End + ")\n";
            }
            return s;
        }

    }
}
