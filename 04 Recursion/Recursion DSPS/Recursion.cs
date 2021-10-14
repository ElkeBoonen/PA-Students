using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Recursion_DSPS
{
    class Recursion
    {
        public string Path { get; set; }
        public Recursion(string path)
        {
            Path = path;
        }

        public string FindTheKey()
        {
            List<string> list = new List<string>();
            //could also use a queue, but we can't use 
            //addRange with a queue, so that's why we 
            //are using a list

            list.AddRange(Directory.GetDirectories(Path));

            while (list.Count > 0)
            {
                string item = list[0];
                list.RemoveAt(0);

                string[] folders = Directory.GetDirectories(item);
                string[] files = Directory.GetFiles(item);

                if (files.Length > 0) return item;
                else if (folders.Length > 0) list.AddRange(folders);
            }
            return "";
        }
        public string FindTheKeyR(string path)
        {
            foreach (var item in Directory.GetFileSystemEntries(path))
            {
                if (Directory.Exists(item))
                {
                    string result = FindTheKeyR(item);
                    if (result != null) return result;
                }
                else return item;
            }
            return null;
        }
        public int Factorial(int n)
        {
            if (n == 0) return 1;
            int result = n;
            for (int i = n-1; i > 0; i--)
            {
                result *= i;
                //Console.WriteLine(i + " " + result);
            }
            return result;
        }

        public int FactorialR(int n)
        {
            //Console.WriteLine("call " + n);
            if (n == 0) return 1;
            return n*FactorialR(n - 1);
        }

        public int FactorialS(int n)
        {
            Stack<int> stack = new Stack<int>();
            for (int i = n; i > 0; i--) stack.Push(i);

            int result = 1;
            while (stack.Count > 0)
            {
                result *= stack.Pop();
            }
            return result;
        }

        public void Print(string[] words)
        {
            foreach (var item in words)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void PrintR(string[] words, int index)
        {
            if (index < words.Length)
            {
                Console.Write(words[index] + " ");
                PrintR(words, ++index); 
                //index++ will never work = stack overflow!!!
                //index + 1 --> will work!

            }
            else Console.WriteLine();
        }
    }
}
