namespace DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scheduling activities = new Scheduling();

            /*
                 string[] classes = { "art", "eng", "math", "cs", "music"};
                 double[] start = { 9,9.5,10,10.5,11};
                 double[] end = { 10,10.5,11,11.5,12 };
             
             */

            activities.AddClass("art", 9, 10);
            activities.AddClass("eng", 9.5, 10.5);
            activities.AddClass("math", 10, 11);
            activities.AddClass("cs", 10.5, 11.5);
            activities.AddClass("music", 11, 12);


            activities.Schedule();
        }
    }
}