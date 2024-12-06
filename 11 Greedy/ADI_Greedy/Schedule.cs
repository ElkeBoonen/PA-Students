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
            List<Lesson> list = new List<Lesson>();

            this.Lessons.Sort();

            list.Add(Lessons[0]);
            for (int i = 1; i < this.Lessons.Count; i++)
            {
                if (Lessons[i].Start >= list.Last().End)
                {
                    list.Add(Lessons[i]);
                }
            }

            return list;
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
