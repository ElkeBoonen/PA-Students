using System;
using System.Security.Cryptography;
using System.Text;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {

            string[] classes = { "art", "eng", "math", "cs", "music"};
            double[] start = { 9,9.5,10,10.5,11};
            double[] end = { 10,10.5,11,11.5,12 };

            Greedy greedy = new Greedy();

            List<string> activities = greedy.Activities(classes, start, end);
            Console.WriteLine(string.Join(" ", activities));

        }
    }
} 