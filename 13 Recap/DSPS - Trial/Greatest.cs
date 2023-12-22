using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS___Trial
{
    public class Greatest
    {
        public int[] Digits { get; set; }

        public Greatest(int[] input)
        {
            Digits = input;
        }


        public int BruteForce()
        {
            int max = int.MinValue;                 //space complexity O(1)
            List<int> numbers = new List<int>();    //space complexity O(n^2) 
            
            //time complexity = O(n^2)
            for (int i = 0; i < Digits.Length; i++)
            {
                for (int j = 0; j < Digits.Length; j++)
                {
                    if (i != j)
                    { 
                        string nr = Digits[i].ToString()+ Digits[j].ToString();
                        if (max < Convert.ToInt32(nr))
                        {
                            max = Convert.ToInt32(nr);
                        }

                        numbers.Add(Convert.ToInt32(nr));
                    }
                }
            }
            //numbers.Sort()
            //return numbers[numbers.Count-1]
            //return numbers.Max();
            return max;
        }

        public int BruteForce(int index, int max)
        {
            if (index == Digits.Length) return max;
            string digit1 = Digits[index].ToString();
            for (int i = 0; i < Digits.Length; i++)
            {
                if (i != index)
                {
                    string digit2 = Digits[i].ToString();
                    int current = Int32.Parse(digit1 + digit2);
                    if (current > max) max = current;
                }
            }
            return BruteForce(++index, max);
        }

        public int Linear()
        {
            int max = Int32.MinValue;
            int semax = Int32.MinValue;

            foreach (var item in Digits)
            {
                if (item > max) max = item;
                else if (item > semax)
                {
                    semax = item;
                }
            }
            return Int32.Parse(max.ToString() + semax.ToString());
        }

        public int Other()
        {
            Number num = new Number();
            foreach (var item in Digits)
            {
                num.InsertDigit(item);
            }
            return num.Dump();
        }

        public int Greedy()
        { 
            Array.Sort(Digits);
            int digit1 = Digits[Digits.Length - 1];
            int digit2 = Digits[Digits.Length - 2];

            return Int32.Parse(digit1.ToString() + digit2.ToString());  
        }


    }
}
