using System;
using System.Security.Cryptography;
using System.Text;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {

            //in main
            BinaryTree tree = new BinaryTree();

            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(2);
            tree.Add(4);
            tree.Add(6);
            tree.Add(8);

            Console.WriteLine("IN ORDER:");
            tree.InOrder();
            Console.WriteLine("\nPRE ORDER:");
            tree.PreOrder();
            Console.WriteLine("\nPOST ORDER:");
            tree.PostOrder();

            Console.WriteLine("\n\n0? " + tree.Search(0));
            Console.WriteLine("6? " + tree.Search(6));
            Console.WriteLine(tree.Min());
            Console.WriteLine(tree.Max());


        }
    }
} 