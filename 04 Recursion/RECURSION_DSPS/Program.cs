using TM.ProgrammingAdvanced;

namespace RECURSION_DSPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string basefolder = Data.Folders(@"C:\");
            string basefolder = @"C:\3orhyvogped";
            
            KeyInBox keyInBox = new KeyInBox();
            keyInBox.Count = 0;
            Console.WriteLine(keyInBox.Algorithm1(basefolder) + " --> " + keyInBox.Count );

            keyInBox.Count = 0;
            Console.WriteLine(keyInBox.Algorithm2(basefolder) + " --> " + keyInBox.Count);
        
        
            Factorial factorial = new Factorial();
            Console.WriteLine(factorial.Algorithm1(7));
            Console.WriteLine(factorial.Algorithm2(7));

            Console.WriteLine(factorial.Algorithm2(0));


            Exercises exercise = new Exercises();
            Console.WriteLine(exercise.Sum(3));

            Console.WriteLine(exercise.Count(2347));

            Console.WriteLine(exercise.Reverse("APPLE"));
            Console.WriteLine(exercise.Reverse1("APPLE"));

        }
    }
}
