using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS___Trial
{
    public class Solutions
    {
        public int[] Nrs { get; set; }

        public Solutions(int[] nrs)
        {
            Nrs = nrs;
        }

        public int BruteForce()
        {
            int max = Int32.MinValue;           //space O(1)
            List<int> nrs = new List<int>();    //space O(n^2)

            for (int i = 0; i < Nrs.Length; i++)    //time O(n^2)
            {
                for (int j = 0; j < Nrs.Length; j++)
                {
                    if (i != j)
                    {
                        int current = Convert.ToInt32(Nrs[i].ToString() + Nrs[j].ToString());
                        if (max < current) max = current;
                        nrs.Add(current);
                    }
                }
            }

            return max;
            //return nrs.Max(); //
        }

        public int Greedy()
        {
            Array.Sort(Nrs); // O(nlogn)
            Array.Reverse(Nrs);

            return Convert.ToInt32(String.Join("", Nrs[0], Nrs[1]));
        }

        public int Linear()
        {
            int max = Int32.MinValue;            //space O(1)
            int semax = Int32.MinValue;

            for (int i = 0; i < Nrs.Length; i++) //time O(n)
            {
                if (max < Nrs[i])
                {
                    semax = max;
                    max = Nrs[i];
                }
                else if (semax < Nrs[i])
                {
                    semax = Nrs[i];
                }
            }

            
            return Convert.ToInt32(max.ToString() + semax.ToString());
        }
    }
}
