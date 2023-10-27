using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    internal class Hanoi
    {
        internal void Solve(int disks, char from, char to, char other)
        {
            if (disks == 1) Console.WriteLine($"{disks}: {from} --> {to}");
            else
            {
                Solve(disks - 1, from, other, to);
                Console.WriteLine($"{disks}: {from} --> {to}");
                Solve(disks-1, other, to, from);  
            }

        }
    }
}
