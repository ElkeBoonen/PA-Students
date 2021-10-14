using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_in_folder___IMS
{
    class Recursion
    {
        public string Path { get; set; }
        public Recursion(string path)
        {
            Path = path;
        }

        public string Algorithm1()
        {
            List<string> list = new List<string>();
            list.AddRange(Directory.GetDirectories(Path));

            while (list.Count > 0)
            {
                string element = list[0];
                list.RemoveAt(0);

                if (Directory.GetFiles(element).Length > 0) return element;
                list.AddRange(Directory.GetDirectories(element));
            }
            return "";
        }

        public string Algorithm2(string path)
        {
            foreach (string item in Directory.GetFileSystemEntries(path))
            {
                if (Directory.Exists(item))
                {
                    string result = Algorithm2(item);
                    if (result != null) return result;

                }
                else return item; //dit is de file!
            }
            return null;
        }

        public int Faculteit(int getal)
        {
            int resultaat = 1;
            for (int i = 1; i <= getal; i++)
            {
                resultaat *= i;
                Console.WriteLine($"i = {i} en resultaat = {resultaat}");
            }
            return resultaat;
        }

        public int FaculteitR(int getal)
        {
            Console.WriteLine($"oproep met getal = {getal}");
            //base case 
            if (getal == 0) return 1;
            //recursieve case
            return getal * FaculteitR(getal - 1);
        }
        public int FaculteitS(int getal)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = getal; i > 0; i--) stack.Push(i);

            int resultaat = 1;
            while (stack.Count > 0)
                resultaat *= stack.Pop();

            return resultaat;
        }

        public void Print(string[] woorden)
        {
            foreach (var item in woorden)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void PrintR(int index, string[] woorden)
        {
            if (index < woorden.Length)
            {
                Console.Write(woorden[index] + " ");
                PrintR(++index, woorden);
                //waarom geen ++ --> postfix operator, oplossen met index+1 of ++index
            }
            else Console.WriteLine();

        }

        public void PrintL(List<string> woorden)
        {
            if (woorden.Count > 0)
            {
                Console.Write(woorden[0] + " ");
                woorden.RemoveAt(0);
                PrintL(woorden);
            }
            else Console.WriteLine();

        }
    }
}
