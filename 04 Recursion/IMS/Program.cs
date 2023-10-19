using TM.ProgrammingAdvanced;

namespace IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //check PS       >> cd "C:\rw0azbjcmf3"
            //voor treeview: >> tree /f

            string folder = @"C:\rw0azbjcmf3"; //Data.Folders(@"C:\");
            Console.WriteLine(folder);

            FindKey key = new FindKey();
            key.Count = 0;
            Console.WriteLine("Key --> " + key.Algorithm1(folder) + " Count " + key.Count);
            key.Count = 0;
            Console.WriteLine("Key --> " + key.Algorithm2(folder) + " Count " + key.Count);
        
        
            Factorial factorial = new Factorial();
            Console.WriteLine("7! = " + factorial.Iterative(7));
            Console.WriteLine("7! = " + factorial.Recursive(7));

            Exercises ex = new Exercises();
            Console.WriteLine("Som van 9 --> " + ex.Sum(9));
            Console.WriteLine("Count 38000765 --> " + ex.Count(38000765));

            ex.For(new int[] { 1, 4, 7, 19, 20, 6 });
            Console.WriteLine(ex.For(9,-8));
            Console.WriteLine(ex.Reverse("dit is een woord"));
        }
    }
}