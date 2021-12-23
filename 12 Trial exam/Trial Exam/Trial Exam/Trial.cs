using System;
using System.Collections.Generic;
using System.Text;

namespace Trial_Exam
{
    class Trial
    {
        /*Beschouw een reeks gehele getallen A = {a0_, a_1, ... a_n}. 
         * We zeggen dat het absolute verschil tussen twee elementen, a_i en a_j (met i != j) 
         * de absolute waarde van a_i - a_j is. Zoek het kleinste absolute verschil in de reeks!*/

        public int[] Numbers { get; set; }
        int _best = Int32.MaxValue;

        public Trial(int[] numbers)
        {
            Numbers = numbers;
        }

        public int BruteForce()
        {
            //List<int> values = new List<int>();
            int min = Int32.MaxValue;
            for (int i = 0; i < Numbers.Length; i++)
            {
                for (int j = 0; j < Numbers.Length; j++) //O(n^2)
                {
                    //if n = 20 --> 20^2 = 400
                    if (i != j)
                    {
                        int dif = Math.Abs(Numbers[i] - Numbers[j]);
                        if (dif < min) min = dif;
                        //values.Add(dif);
                    }
                }
            }

            //values.Sort(); O(n^2 + nlogn)
            //return values[0];
            return min;
        }

        public int Greedy()
        {
            int[] array = new int[Numbers.Length];
            Array.Copy(Numbers, array, Numbers.Length);

            Array.Sort(array); //O(nlogn)
            int min = Int32.MaxValue;
            for (int i = 0; i < array.Length-1; i++)
            { //O(n)            {
                int dif = Math.Abs(array[i] - array[i+1]);
                if (dif < min) min = dif;
            }
            return min;
            //--> O(nlogn + n)
        }

        public int RecursionAron(int i, int j)
        {
            if (i < Numbers.Length)
            {
                if (j < Numbers.Length)
                {
                    if (i != j)
                    {
                        _best = Math.Min(_best, Math.Abs(Numbers[i] - Numbers[j]));
                        RecursionAron(i, ++j);
                    }
                    else RecursionAron(i, ++j);
                }
                else RecursionAron(++i, 0);
            }
            return _best;
        }

        public int RecursionAndreas(int i, int j, int min)
        {
            Console.WriteLine(i + " " + j);
            if (i == Numbers.Length - 2) return Math.Min(min, Math.Abs(Numbers[i] - Numbers[j]));
            else if (j - i == 1)
            {
                i++;
                j = Numbers.Length - 1;
            }
            else
            {
                j--;
            }
            min = Math.Min(min, Math.Abs(Numbers[i] - Numbers[j]));
            return RecursionAndreas(i, j, min);
        }

        public int Recursion(int i, int j)
        {
            if (i == Numbers.Length) return Int32.MaxValue;

            int abs = Int32.MaxValue;
            if (i != j) abs = Math.Abs(Numbers[i] - Numbers[j]);
            if (j == Numbers.Length - 1) return Math.Min(abs, Recursion(i + 1, 0));
            return Math.Min(abs, Recursion(i, j+1));
        }

        public int Tabulation()
        {
            int[,] tabulation = new int[Numbers.Length, Numbers.Length];

            for (int i = 0; i < Numbers.Length; i++)
            {
                for (int j = 0; j < Numbers.Length; j++)
                {
                    int abs = Int32.MaxValue;
                    if (i != j) abs = Math.Abs(Numbers[i] - Numbers[j]);

                    if (i == 0)
                    {
                        if (j > i) tabulation[i, j] = Math.Min(abs, tabulation[i, j - 1]);
                        else tabulation[i, j] = abs; //i==0 & j ==0
                    }
                    else
                    { 
                        if (j == 0) tabulation[i, j] = Math.Min(abs, tabulation[i-1, Numbers.Length-1]);
                        else tabulation[i, j] = Math.Min(abs, tabulation[i, j - 1]);
                    }

                }
            }
            return tabulation[Numbers.Length - 1, Numbers.Length - 1];
        
        }

    }
}
