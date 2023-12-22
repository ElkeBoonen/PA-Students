using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPS___Trial
{
    public class Number
    {
        public int Digit1 { get; set; }
        public int Digit2 { get; set; }

        public Number()
        {
            Digit1 = 0;
            Digit2 = 0;
        }

        public void InsertDigit(int digit)
        {
            if (digit > Digit1)
            {
                int current = Digit1;
                Digit1 = digit;

                if (current > Digit2)
                {
                    Digit2 = current;
                }

            }
            else if (digit > Digit2)
            {
                Digit2 = digit;
            }
        }

        public int Dump()
        {
            return Int32.Parse(Digit1.ToString() + Digit2.ToString());
        }
    }
}
