using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem1849
    {
        List<int> nums = new List<int>();
        public bool SplitString(string s)
        {
            long first = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                first *= 10;
                first += s[i] - '0';

                if (CanSplit(i + 1, first)) return true;
            }

            return false;

            bool CanSplit(int start, long previous)
            {
                if (start == s.Length) return true;

                long current = 0;
                for (int i = start; i < s.Length; i++)
                {
                    current *= 10;
                    current += s[i] - '0';

                    if (current >= previous) break;

                    if (previous - current != 1) continue;

                    if (CanSplit(i + 1, current)) return true;
                }

                return false;
            }
        }

        private void backtracing(int index, string s)
        {
            string left = string.Empty, right = string.Empty;
            for (int cnt = index; cnt < s.Length; cnt++)
            {
                
            }
        }
    }
}
