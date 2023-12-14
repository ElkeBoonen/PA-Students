namespace DSPS
{

    public class Class : IComparable
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

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
    public class Scheduling
    {
        List<Class> classes = new List<Class>();

        public Scheduling()
        {
            classes.Sort();
        }

        public void AddClass(string name, double start, double end)
        {
            classes.Add(new Class(name, start, end));
        }

        internal void Schedule()
        {
            throw new NotImplementedException();
        }
    }
}