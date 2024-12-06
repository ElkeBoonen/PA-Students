namespace ADI_Gredy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();
            schedule.Lessons.Add(new Lesson("music", 11, 12));
            schedule.Lessons.Add(new Lesson("art", 9, 10));
            schedule.Lessons.Add(new Lesson("math", 10, 11));
            schedule.Lessons.Add(new Lesson("eng", 9.5, 10.5));
            schedule.Lessons.Add(new Lesson("cs", 10.5, 11.5));

            Console.WriteLine(schedule.ToString());
            schedule.Lessons.Sort();
            Console.WriteLine(schedule.ToString());


        }
    }
}
