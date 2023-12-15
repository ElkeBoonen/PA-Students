namespace IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course("art", 9, 10));
            courses.Add(new Course("math", 10, 11));
            courses.Add(new Course("eng", 9.50, 10.50));
            courses.Add(new Course("music", 11, 12));
            courses.Add(new Course("cs", 10.50, 11.50));

            Schedule schedule = new Schedule(courses);
            Console.WriteLine(schedule);
        }
    }
}