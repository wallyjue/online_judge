using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem779
    {
        public int KthGrammar(int n, int k)
        {
            string one = "0";
            string curr = one, next = one;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < curr.Length; j++)
                {
                    if (curr[j] == 0)
                    {
                        next = $"{next}01"; 
                    }
                    else
                    {
                        next = $"{next}10";
                    }
                }
                curr = next;
            }
            Console.WriteLine(curr);
            return curr[k-1] == '0' ? 0 : 1;
        }
    }
}
