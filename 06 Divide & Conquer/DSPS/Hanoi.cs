using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS
{
    class Hanoi
    {
        public void Solve(int number, char from, char to, char other)
        {
            //1: A to C
            if (number == 1) Console.WriteLine($"{number}: {from} to {to}");
            else
            {
                //1: A to B
                //2: A to C
                //1: B to C
                Solve(number - 1, from, other, to);
                Console.WriteLine($"{number}: {from} to {to}");
                Solve(number - 1, other, to, from);
            }

        }

    }
}
