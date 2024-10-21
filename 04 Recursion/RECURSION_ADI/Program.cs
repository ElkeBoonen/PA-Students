using TM.ProgrammingAdvanced;

namespace RECURSION_ADI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string folder = Data.Folders(@"C:\");
            //jtahfcqoyt0 gwiauxqo213 5ijdhxvcgzg 3orhyvogped
            string folder = @"C:\jtahfcqoyt0";
            
            KeyInBox keyInBox = new KeyInBox();

            keyInBox.Count = 0;
            Console.WriteLine(keyInBox.Algorithm1(folder) + " --> " + keyInBox.Count);

            keyInBox.Count = 0;
            Console.WriteLine(keyInBox.Algorithm2(folder) + " --> " + keyInBox.Count);
        
        
            Factorial factorial = new Factorial();
            Console.WriteLine("7! = " + factorial.Algorithm1(7));
            Console.WriteLine("7! = " + factorial.Algorithm2(7));

            //Console.WriteLine("0! = " + factorial.Algorithm2(0)); --> STACK OVERFLOW


            Exercises exercise = new Exercises();
            Console.WriteLine("n = 10 --> " + exercise.Sum(10));
            Console.WriteLine("n = 10 --> " + exercise.Sum1(10));
            Console.WriteLine("n = 10 --> " + exercise.Sum2(10,0,0));

            Console.WriteLine(exercise.Reverse("KIWI"));
            Console.WriteLine(exercise.Reverse1("KIWI"));



        }
    }
}
