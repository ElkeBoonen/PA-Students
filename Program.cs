using System;
using System.Security.Cryptography;
using System.Text;

namespace PAStudents
{

    class Program
    {
        static void Main(string[] args)
        {
            HashMap map = new HashMap(5);

            map.AddItem("apple", 0.67);
            map.AddItem("pear", 0.79);
            map.AddItem("eggs", 2.49);
            map.AddItem("milk", 1.49);
            map.AddItem("avocado", 1.49);
            map.AddItem("bread", 2.49);
            map.AddItem("banana", 1.09);
            Console.WriteLine(map.ToString());
            Console.WriteLine("Price of eggs: " + map.GetPrice("eggs"));
            Console.WriteLine(map.ToString());


        }
    }
} 