using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Recursion___DSPS
{
    class Recursion
    {

        public string FindKeyAlgorithm1(string path)
        { 
            List<string> list = new List<string>();
            list.Add(path);

            while (list.Count != 0)
            {
                //grabbing a box!
                string box = list[0];
                list.RemoveAt(0);

                if (Directory.GetFiles(box).Length > 0)
                {
                    return box;
                }
                list.AddRange(Directory.GetDirectories(box));
            }
            return "Nothing found!";
        }

        public string FindKeyAlgorithm2(string path)
        {
            foreach (string item in Directory.GetFileSystemEntries(path))
            {
                if (Directory.Exists(item))
                {
                    //return FindKeyAlgorithm2(item);
                    string result = FindKeyAlgorithm2(item);
                    if (result != "nothing found") return result;
                }
                else return item;
            }
            return "nothing found";
        }

        public string FindKeyAlgorithm3(string path)
        {
            if (Directory.GetFiles(path).Length>0)
            {
                return path;
            }
            foreach (var item in Directory.GetDirectories(path))
            {
                if (Directory.Exists(item))
                {
                    //return FindKeyAlgorithm2(item);
                    string result = FindKeyAlgorithm2(item);
                    if (result != "nothing found") return result;
                }
            }
            return "nothing found";
        }


        public int FactorialIterative(int n)
        { 
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;   //factorial *= i;
            }
            return factorial;
        }

        public int FactorialRecursive(int n)
        {
            if (n <= 1) return 1;                  //if (n==1 || n==0)
            return n * FactorialRecursive(n-1);    //don't use n--!!! post decrement, changes after call
        }

        public int FactorialStack(int n)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 1; i <= n; i++)
            {
                stack.Push(i);
            }

            int factorial = 1;
            while (stack.Count != 0)
            { 
                factorial *= stack.Pop();
            }
            return factorial;
        }

        public double Power(int number, int power)
        {
            if (power == 0) return 1;
            if (power > 0) return number * Power(number, power-1);  //positive powers
            else return Power(number, power+1) / number;            //negative powers
        }

        public string Count(int start, int end)
        {
            if (end - start <= 0) return end.ToString();
            return start.ToString() + " " + Count(++start, end);
        }

        public string Count2(int start, int end)
        {
            if (start == end) return start.ToString();
            return start.ToString() + " " + Count2(start+1, end);
        }

        //Write a program to calculate the sum of a list of numbers
        public int Sum(int[] array, int index = 0)
        {
            if (index == array.Length) return 0;
            return array[index] + Sum(array, index+1);
        }

        public int Sum(List<int> list)
        {
            if (list.Count == 0) return 0;

            int number = list[0];
            list.RemoveAt(0);

            return number + Sum(list);
        }

    }
}
