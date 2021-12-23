using System;

namespace Trial_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nrs = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);

            Trial trial = new Trial(new int[] { 0, -7, 3 }); //3

            Console.WriteLine("BRUTE FORCE : " + trial.BruteForce());
            Console.WriteLine("GREEDY : " + trial.Greedy());
            Console.WriteLine("RECURSION ARON : " + trial.RecursionAron(0,0));
            Console.WriteLine("RECURSION ANDREAS : " + trial.RecursionAndreas(0,trial.Numbers.Length-1, Int32.MaxValue));
            Console.WriteLine("RECURSION : " + trial.Recursion(0, 0));
            Console.WriteLine("TABULATION : " + trial.Tabulation());

        }
    }
}
