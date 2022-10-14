using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Recursion___IMS
{
    class Recursion
    {

        public int count { get; set; }
        public string FindKey(string foldername)
        {
            List<string> list = new List<string>();
            list.Add(foldername);

            while (list.Count > 0)
            {
                count++;
                string item = list[0];
                list.RemoveAt(0);
                if (Directory.GetFiles(item).Length > 0) return item;
                else 
                {
                    FileAttribute file = (FileAttribute)File.GetAttributes(item);
                    if (file == FileAttribute.Directory)
                    {
                        list.AddRange(Directory.GetDirectories(item));
                    }
                }
            }
            return "niets gevonden!";
        }

        public string FindKeyREC(string foldername)
        {
            foreach (var item in Directory.GetFileSystemEntries(foldername))
            {
                count++;
                if ((FileAttribute)File.GetAttributes(item) != FileAttribute.Directory)
                {
                    return item;
                }
                else
                {
                    string result = FindKeyREC(item);
                    if (result!="not found") return result;
                }
            }
            return "not found";
        }

        public int Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public int FactorialREC(int n)
        {
            //Console.WriteLine("call " + n);
            if (n <= 1) return 1;
            return n * FactorialREC(n - 1);
        }

        /*Program to calculate power using recursion*/
        public int Pow(int x, int n)
        {
            if (n == 0) return 1;
            return x * Pow(x, --n); //let op met n-- --> stackoverflow
                                    //n wordt pas gedecrementeerd NADAT functie opnieuw werd opgeroepen
        }

        /*  Write a program to print the first 50 natural numbers using recursion. Go to the editor
            1  2  3  4  5  6  7  8  9  10  11  12  13 14  15  16  17  18  19  20  21 ...
            Adjust the program so it outputs all numbers between two given integer.*/
        public string Print(int start, int end)
        {
            //if (start == end) return start.ToString();
            if (start == end) return end.ToString();
            return start + " " + Print(start + 1, end);
        }

        /*Write a program to calculate the sum of a list of numbers*/
        /*versie met array --> laat index opschuiven!*/
        public int Sum(int[] array, int index = 0)
        {
            if (index == array.Length) return 0;
            return array[index] + Sum(array, index + 1);
        }

        /*Write a program to calculate the sum of a list of numbers*/
        /*versie met list --> laat list kleiner worden!*/
        public int Sum(List<int> list)
        {
            if (list.Count == 0) return 0;
            int getal = list[0];
            list.RemoveAt(0);
            return getal + Sum(list);
        }

        /*Write a program to calculate the sum of a list of numbers*/
        /*versie met stack --> laat stack kleiner worden!*/
        public int Sum(Stack<int> stack)
        {
            if (stack.Count == 0) return 0;
            return stack.Pop() + Sum(stack);
        }
    }
}
