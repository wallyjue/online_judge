using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    internal class Problem509
    {
        public int Fib(int n)
        {
            Hashtable table = new Hashtable();

            table.Add(0, 0);
            table.Add(1, 1);
            for(int i = 2; i <= n; i++)
            {
                int one = (int)table[i - 1];
                table.Add(i, (int)table[i - 1] + (int)table[i - 2]);
            }
            return (int)table[n];
        }
    }
}
