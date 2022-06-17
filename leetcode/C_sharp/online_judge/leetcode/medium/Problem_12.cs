using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.medium
{
    internal class Problem_12
    {
        public string IntToRoman(int num)
        {
            string ret = string.Empty;
            int dec = num % 10;
            int ten = (num % 100) / 10;
            int hundred = (num % 1000) / 100;
            int thousand = num / 1000;

            return ret;
        }
    }
}
