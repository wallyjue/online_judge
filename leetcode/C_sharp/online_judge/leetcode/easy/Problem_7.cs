using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    class Problem_7
    {
		public int Reverse(int x)
		{
			bool isNegative = x < 0;
			int[] numbers = new int[10];
			int decimals = 0;
			int ret = 0;
			x = isNegative ? -x : x;

			for(int radix = 0, number = 0, mod = 10, power = 1; radix < 10; radix++)
			{
				numbers[radix] = radix < 9 ? (x % mod) / power : x / power;
				if (numbers[radix] != 0) decimals = radix;
				mod *= 10;
				power *= 10;
			}

			for (int cnt = 0; cnt <= decimals; cnt++)
			{
				if (ret * 10 / 10 != ret) return 0;
				ret = ret * 10 + numbers[cnt];
			}
			return isNegative ? -ret : ret;
		}
	}
}
