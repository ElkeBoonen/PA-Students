namespace DSPS
{

    public class Class : IComparable<Class>
    {
        public string Name { get; set; }
        public double Start { get; set; }
        public double End { get; set; }

        public Class(string name, double start, double end)
        {
            Name = name;
            Start = start;
            End = end;
        }

        public int CompareTo(Class other)
        {
            if (this.End < other.End) return -1;
            if (this.End > other.End) return 1;
            return 0;
        }
    }
    public class Scheduling
    {
        List<Class> classes = new List<Class>();

        public void AddClass(string name, double start, double end)
        {
            classes.Add(new Class(name, start, end));
        }

        public List<Class> Schedule()
        {
            classes.Sort();
            List<Class> schedule = new List<Class>();

            schedule.Add(classes[0]);

            for (int i = 1; i < classes.Count; i++)
            {
                if (classes[i].Start >= schedule[schedule.Count - 1].End)
                { 
                    schedule.Add(classes[i]);
                }
            }

            return schedule;
        }

        public override string ToString()
        {
            classes.Sort();
            string s = "";
            foreach (var item in classes)
            {
                s += item.Name + " " + item.Start + ":" + item.End + "\n";
            }
            return s;
        }
    }
}