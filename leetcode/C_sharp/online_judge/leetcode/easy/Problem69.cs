using System;
using System.Collections.Generic;
using System.Text;

namespace online_judge.leetcode.easy
{
    class Problem69
    {
		public int MySqrt(int x)
		{
			int ret = 1;
			while( (x/ret) >= ret)
			{
				ret++;
			}
			return ret-1;
		}
	}
}
